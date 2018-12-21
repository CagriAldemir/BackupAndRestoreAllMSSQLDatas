namespace WindowsFormsApplication1
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnectAndGetTableNames = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkYedektenGeriYukle = new System.Windows.Forms.CheckBox();
            this.chkYedekle = new System.Windows.Forms.CheckBox();
            this.btnGozat = new System.Windows.Forms.Button();
            this.fBrwDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnConnectAndGetTableNames
            // 
            this.btnConnectAndGetTableNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnectAndGetTableNames.Location = new System.Drawing.Point(117, 138);
            this.btnConnectAndGetTableNames.Name = "btnConnectAndGetTableNames";
            this.btnConnectAndGetTableNames.Size = new System.Drawing.Size(180, 23);
            this.btnConnectAndGetTableNames.TabIndex = 21;
            this.btnConnectAndGetTableNames.Text = "BAĞLAN VE YEDEKLE";
            this.btnConnectAndGetTableNames.UseVisualStyleBackColor = true;
            this.btnConnectAndGetTableNames.Click += new System.EventHandler(this.btnConnectAndGetTableNames_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 20);
            this.txtPassword.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ŞİFRE:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(117, 60);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(180, 20);
            this.txtUserName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "KULLANICI ADI:";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(117, 112);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(180, 20);
            this.txtBackupPath.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "YEDEK YOLU:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(117, 34);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(180, 20);
            this.txtServerName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "SUNUCU ADRESİ:";
            // 
            // chkYedektenGeriYukle
            // 
            this.chkYedektenGeriYukle.AutoSize = true;
            this.chkYedektenGeriYukle.Location = new System.Drawing.Point(117, 5);
            this.chkYedektenGeriYukle.Name = "chkYedektenGeriYukle";
            this.chkYedektenGeriYukle.Size = new System.Drawing.Size(151, 17);
            this.chkYedektenGeriYukle.TabIndex = 24;
            this.chkYedektenGeriYukle.Text = "YEDEKTEN GERİ YÜKLE";
            this.chkYedektenGeriYukle.UseVisualStyleBackColor = true;
            this.chkYedektenGeriYukle.CheckedChanged += new System.EventHandler(this.chkYedektenGeriYukle_CheckedChanged);
            // 
            // chkYedekle
            // 
            this.chkYedekle.AutoSize = true;
            this.chkYedekle.Checked = true;
            this.chkYedekle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkYedekle.Location = new System.Drawing.Point(36, 5);
            this.chkYedekle.Name = "chkYedekle";
            this.chkYedekle.Size = new System.Drawing.Size(75, 17);
            this.chkYedekle.TabIndex = 25;
            this.chkYedekle.Text = "YEDEKLE";
            this.chkYedekle.UseVisualStyleBackColor = true;
            this.chkYedekle.CheckedChanged += new System.EventHandler(this.chkYedekle_CheckedChanged);
            // 
            // btnGozat
            // 
            this.btnGozat.Location = new System.Drawing.Point(303, 112);
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Size = new System.Drawing.Size(29, 20);
            this.btnGozat.TabIndex = 26;
            this.btnGozat.Text = "...";
            this.btnGozat.UseVisualStyleBackColor = true;
            this.btnGozat.Click += new System.EventHandler(this.btnGozat_Click);
            // 
            // fBrwDialog
            // 
            this.fBrwDialog.ShowNewFolderButton = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 173);
            this.Controls.Add(this.btnGozat);
            this.Controls.Add(this.chkYedekle);
            this.Controls.Add(this.chkYedektenGeriYukle);
            this.Controls.Add(this.btnConnectAndGetTableNames);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBackupPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSSQL Database Backup/Restore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectAndGetTableNames;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkYedektenGeriYukle;
        private System.Windows.Forms.CheckBox chkYedekle;
        private System.Windows.Forms.Button btnGozat;
        private System.Windows.Forms.FolderBrowserDialog fBrwDialog;
    }
}

