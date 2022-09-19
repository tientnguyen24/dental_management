
namespace QuanLyNhaKhoa
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
            this.pnlLoginUsername = new System.Windows.Forms.Panel();
            this.txbLoginUserName = new System.Windows.Forms.TextBox();
            this.lbLoginUsername = new System.Windows.Forms.Label();
            this.pnlLoginPassword = new System.Windows.Forms.Panel();
            this.txbLoginPassWord = new System.Windows.Forms.TextBox();
            this.lbLoginPassword = new System.Windows.Forms.Label();
            this.pnlLoginAction = new System.Windows.Forms.Panel();
            this.btnLoginCancel = new System.Windows.Forms.Button();
            this.btnLoginAccept = new System.Windows.Forms.Button();
            this.pnlLoginUsername.SuspendLayout();
            this.pnlLoginPassword.SuspendLayout();
            this.pnlLoginAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoginUsername
            // 
            this.pnlLoginUsername.Controls.Add(this.txbLoginUserName);
            this.pnlLoginUsername.Controls.Add(this.lbLoginUsername);
            this.pnlLoginUsername.Location = new System.Drawing.Point(12, 12);
            this.pnlLoginUsername.Name = "pnlLoginUsername";
            this.pnlLoginUsername.Size = new System.Drawing.Size(327, 41);
            this.pnlLoginUsername.TabIndex = 0;
            // 
            // txbLoginUserName
            // 
            this.txbLoginUserName.AcceptsTab = true;
            this.txbLoginUserName.Location = new System.Drawing.Point(129, 15);
            this.txbLoginUserName.Name = "txbLoginUserName";
            this.txbLoginUserName.Size = new System.Drawing.Size(180, 20);
            this.txbLoginUserName.TabIndex = 1;
            // 
            // lbLoginUsername
            // 
            this.lbLoginUsername.AutoSize = true;
            this.lbLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginUsername.Location = new System.Drawing.Point(3, 13);
            this.lbLoginUsername.Name = "lbLoginUsername";
            this.lbLoginUsername.Size = new System.Drawing.Size(120, 20);
            this.lbLoginUsername.TabIndex = 0;
            this.lbLoginUsername.Text = "Tên đăng nhập:";
            // 
            // pnlLoginPassword
            // 
            this.pnlLoginPassword.Controls.Add(this.txbLoginPassWord);
            this.pnlLoginPassword.Controls.Add(this.lbLoginPassword);
            this.pnlLoginPassword.Location = new System.Drawing.Point(12, 59);
            this.pnlLoginPassword.Name = "pnlLoginPassword";
            this.pnlLoginPassword.Size = new System.Drawing.Size(327, 41);
            this.pnlLoginPassword.TabIndex = 1;
            // 
            // txbLoginPassWord
            // 
            this.txbLoginPassWord.AcceptsTab = true;
            this.txbLoginPassWord.Location = new System.Drawing.Point(129, 15);
            this.txbLoginPassWord.Name = "txbLoginPassWord";
            this.txbLoginPassWord.PasswordChar = '*';
            this.txbLoginPassWord.Size = new System.Drawing.Size(180, 20);
            this.txbLoginPassWord.TabIndex = 2;
            // 
            // lbLoginPassword
            // 
            this.lbLoginPassword.AutoSize = true;
            this.lbLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginPassword.Location = new System.Drawing.Point(3, 13);
            this.lbLoginPassword.Name = "lbLoginPassword";
            this.lbLoginPassword.Size = new System.Drawing.Size(79, 20);
            this.lbLoginPassword.TabIndex = 2;
            this.lbLoginPassword.Text = "Mật khẩu:";
            // 
            // pnlLoginAction
            // 
            this.pnlLoginAction.Controls.Add(this.btnLoginCancel);
            this.pnlLoginAction.Controls.Add(this.btnLoginAccept);
            this.pnlLoginAction.Location = new System.Drawing.Point(12, 106);
            this.pnlLoginAction.Name = "pnlLoginAction";
            this.pnlLoginAction.Size = new System.Drawing.Size(327, 53);
            this.pnlLoginAction.TabIndex = 2;
            // 
            // btnLoginCancel
            // 
            this.btnLoginCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoginCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLoginCancel.Location = new System.Drawing.Point(7, 13);
            this.btnLoginCancel.Name = "btnLoginCancel";
            this.btnLoginCancel.Size = new System.Drawing.Size(100, 30);
            this.btnLoginCancel.TabIndex = 4;
            this.btnLoginCancel.Text = "Thoát";
            this.btnLoginCancel.UseVisualStyleBackColor = false;
            this.btnLoginCancel.Click += new System.EventHandler(this.btnLoginCancel_Click);
            // 
            // btnLoginAccept
            // 
            this.btnLoginAccept.Location = new System.Drawing.Point(209, 13);
            this.btnLoginAccept.Name = "btnLoginAccept";
            this.btnLoginAccept.Size = new System.Drawing.Size(100, 30);
            this.btnLoginAccept.TabIndex = 3;
            this.btnLoginAccept.Text = "Đăng nhập";
            this.btnLoginAccept.UseVisualStyleBackColor = true;
            this.btnLoginAccept.Click += new System.EventHandler(this.btnLoginAccept_Click);
            // 
            // fLogin
            // 
            this.AcceptButton = this.btnLoginAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLoginCancel;
            this.ClientSize = new System.Drawing.Size(354, 161);
            this.Controls.Add(this.pnlLoginAction);
            this.Controls.Add(this.pnlLoginPassword);
            this.Controls.Add(this.pnlLoginUsername);
            this.MaximizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.pnlLoginUsername.ResumeLayout(false);
            this.pnlLoginUsername.PerformLayout();
            this.pnlLoginPassword.ResumeLayout(false);
            this.pnlLoginPassword.PerformLayout();
            this.pnlLoginAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginUsername;
        private System.Windows.Forms.Label lbLoginUsername;
        private System.Windows.Forms.Panel pnlLoginPassword;
        private System.Windows.Forms.Panel pnlLoginAction;
        private System.Windows.Forms.TextBox txbLoginUserName;
        private System.Windows.Forms.TextBox txbLoginPassWord;
        private System.Windows.Forms.Label lbLoginPassword;
        private System.Windows.Forms.Button btnLoginAccept;
        private System.Windows.Forms.Button btnLoginCancel;
    }
}