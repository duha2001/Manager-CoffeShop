namespace QuanLyCafe
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.bntlogin = new DevComponents.DotNetBar.ButtonX();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(36, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "       Mật khẩu: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "       Tên đăng nhập: ";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(195, 81);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(237, 20);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.Text = "24082001";
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(195, 41);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(237, 20);
            this.txbUserName.TabIndex = 1;
            this.txbUserName.Text = "ANHDU2001";
            // 
            // bntlogin
            // 
            this.bntlogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntlogin.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.bntlogin.FocusCuesEnabled = false;
            this.bntlogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntlogin.Image = ((System.Drawing.Image)(resources.GetObject("bntlogin.Image")));
            this.bntlogin.Location = new System.Drawing.Point(250, 117);
            this.bntlogin.Name = "bntlogin";
            this.bntlogin.Size = new System.Drawing.Size(92, 35);
            this.bntlogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bntlogin.Symbol = "";
            this.bntlogin.SymbolColor = System.Drawing.Color.Fuchsia;
            this.bntlogin.TabIndex = 3;
            this.bntlogin.Text = "Đăng nhập";
            this.bntlogin.TextColor = System.Drawing.Color.Black;
            this.bntlogin.UseMnemonic = false;
            this.bntlogin.Click += new System.EventHandler(this.bntlogin_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(348, 117);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 35);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.SymbolColor = System.Drawing.Color.Fuchsia;
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.TextColor = System.Drawing.Color.Black;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(455, 173);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.bntlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txbUserName;
        private DevComponents.DotNetBar.ButtonX bntlogin;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
    }
}

