namespace DownloadImage
{
    partial class Form1
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
            this.login = new System.Windows.Forms.Button();
            this.albumlist = new System.Windows.Forms.ListBox();
            this.get = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSv = new System.Windows.Forms.TextBox();
            this.btndownload = new System.Windows.Forms.Button();
            this.fblogin = new System.Windows.Forms.WebBrowser();
            this.albumname = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(121, 612);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 1;
            this.login.Text = "LogIn";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // albumlist
            // 
            this.albumlist.FormattingEnabled = true;
            this.albumlist.Location = new System.Drawing.Point(1140, 61);
            this.albumlist.Name = "albumlist";
            this.albumlist.Size = new System.Drawing.Size(201, 199);
            this.albumlist.TabIndex = 2;
            this.albumlist.SelectedIndexChanged += new System.EventHandler(this.frndlist_SelectedIndexChanged);
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(1014, 299);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(75, 23);
            this.get.TabIndex = 3;
            this.get.Text = "Get List";
            this.get.UseVisualStyleBackColor = true;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(420, 612);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 4;
            this.logout.Text = "LogOut";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1000, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Save To:";
            // 
            // txtSv
            // 
            this.txtSv.Location = new System.Drawing.Point(1057, 358);
            this.txtSv.Name = "txtSv";
            this.txtSv.Size = new System.Drawing.Size(215, 20);
            this.txtSv.TabIndex = 7;
            // 
            // btndownload
            // 
            this.btndownload.Location = new System.Drawing.Point(1029, 424);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(286, 23);
            this.btndownload.TabIndex = 13;
            this.btndownload.Text = "Download";
            this.btndownload.UseVisualStyleBackColor = true;
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // fblogin
            // 
            this.fblogin.Location = new System.Drawing.Point(82, 28);
            this.fblogin.MinimumSize = new System.Drawing.Size(20, 20);
            this.fblogin.Name = "fblogin";
            this.fblogin.Size = new System.Drawing.Size(760, 567);
            this.fblogin.TabIndex = 14;
            // 
            // albumname
            // 
            this.albumname.FormattingEnabled = true;
            this.albumname.Location = new System.Drawing.Point(892, 61);
            this.albumname.Name = "albumname";
            this.albumname.Size = new System.Drawing.Size(171, 199);
            this.albumname.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(892, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Album Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1137, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Album ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.albumname);
            this.Controls.Add(this.fblogin);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.txtSv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.get);
            this.Controls.Add(this.albumlist);
            this.Controls.Add(this.login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.ListBox albumlist;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSv;
        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.WebBrowser fblogin;
        private System.Windows.Forms.ListBox albumname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

