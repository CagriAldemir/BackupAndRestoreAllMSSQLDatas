using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmMain : Form
    {
        OleDbConnection cnn;
        List<string> fileNameList;

        public FrmMain()
        {
            InitializeComponent();
            fileNameList = new List<string>();
        }

        private string GetFileListFromDirectory()
        {
            string error = "";
            try
            {
                DirectoryInfo d = new DirectoryInfo(txtBackupPath.Text);//Assuming Test is your Folder
                FileInfo[] files = d.GetFiles("*.bak"); //Getting Text files
                foreach (FileInfo file in files)
                {
                    fileNameList.Add(file.Name);
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return error;
        }

        private void btnConnectAndGetTableNames_Click(object sender, EventArgs e)
        {
            string error = "";

            if (!checkAllFields())
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
                return;
            }


            error = ConnectToDatabase();
            if (error != "")
            {
                MessageBox.Show("Veritabanına bağlanılamadı.\n" + error);
                return;
            }


            if (chkYedekle.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Bağlantı başarılı\nYedekleme işlemi başlatılsın mı?", "BAŞARILI", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }

                error = BackupAllDatabases();
                if (error != "")
                {
                    MessageBox.Show("Yedek alınamadı.\n" + error);
                    return;
                }

                MessageBox.Show("Yedekleme başarılı.");
            }
            else if (chkYedektenGeriYukle.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Bağlantı başarılı\nYedekten geri yükleme işlemi başlatılsın mı?", "BAŞARILI", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }

                error = GetFileListFromDirectory();
                if (error != "")
                {
                    MessageBox.Show("Yedek listesi alınamadı.\n" + error);
                }
                for (int i = 0; i < fileNameList.Count; i++)
                {
                    string createDbSQL = string.Format("Create database '{0}'", fileNameList[i]);
                    OleDbCommand cmd = new OleDbCommand(createDbSQL, cnn);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        private bool checkAllFields()
        {
            if (txtServerName.Text == "" || txtUserName.Text == "" || txtPassword.Text == "")
            {
                return false;
            }

            if (!Directory.Exists(txtBackupPath.Text))
            {
                return false;
            }
            return true;
        }

        private string BackupAllDatabases()
        {
            string error = "";
            string backupAllDatabasesQuery = string.Format("DECLARE @name VARCHAR(50)" + "\n" +
                                        "DECLARE @path VARCHAR(256)" + "\n" +
                                        "DECLARE @fileName VARCHAR(256)" + "\n" +
                                        "DECLARE @fileDate VARCHAR(20)" + "\n" +
                                        "SET @path = '{0}'" + "\n" +
                                        "SELECT @fileDate = CONVERT(VARCHAR(20),GETDATE(),112)" + "\n" +
                                        "DECLARE db_cursor CURSOR FOR" + "\n" +
                                        "SELECT name" + "\n" +
                                        "FROM master.dbo.sysdatabases" + "\n" +
                                        "WHERE name NOT IN ('master','model','msdb','tempdb')" + "\n" +
                                        "OPEN db_cursor" + "\n" +
                                        "FETCH NEXT FROM db_cursor INTO @name" + "\n" +
                                        "WHILE @@FETCH_STATUS = 0" + "\n" +
                                        "BEGIN" + "\n" +
                                        "SET @fileName = @path + @name + '-_-' + @fileDate + '.bak'" + "\n" +
                                        "BACKUP DATABASE @name TO DISK = @fileName" + "\n" +
                                        "FETCH NEXT FROM db_cursor INTO @name" + "\n" +
                                        "END" + "\n" +
                                        "CLOSE db_cursor" + "\n" +
                                        "DEALLOCATE db_cursor", txtBackupPath.Text);

            try
            {
                OleDbCommand cmd = new OleDbCommand(backupAllDatabasesQuery, cnn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return error;
        }

        private string ConnectToDatabase()
        {
            string error = "";

            string connetionString = string.Format("Provider=SQLOLEDB;Server={0};Database=master;User Id={1};Password={2};",
                txtServerName.Text, txtUserName.Text, txtPassword.Text);

            cnn = new OleDbConnection(connetionString);
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }

        private void chkYedekle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYedekle.Checked == true)
            {
                btnConnectAndGetTableNames.Text = "BAĞLAN VE YEDEKLE";
            }
            else
            {
                btnConnectAndGetTableNames.Text = "BAĞLAN VE YEDEKTEN GERİ YÜKLE";
            }

            chkYedektenGeriYukle.Checked = !chkYedekle.Checked;
        }

        private void chkYedektenGeriYukle_CheckedChanged(object sender, EventArgs e)
        {
            chkYedekle.Checked = !chkYedektenGeriYukle.Checked;
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            fBrwDialog.ShowDialog();
            string mPath = fBrwDialog.SelectedPath;
            if (mPath != "")
            {
                if (mPath.Substring(mPath.Length - 1) != @"\")
                {
                    mPath += @"\";
                }
                txtBackupPath.Text = mPath;
            }
        }

    }
}
