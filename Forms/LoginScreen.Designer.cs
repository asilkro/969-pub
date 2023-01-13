
namespace Silkroski_C969.Forms
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.UserField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.MaskedTextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserField
            // 
            this.UserField.Location = new System.Drawing.Point(392, 217);
            this.UserField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserField.Name = "UserField";
            this.UserField.Size = new System.Drawing.Size(129, 20);
            this.UserField.TabIndex = 0;
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(548, 217);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(129, 20);
            this.PasswordField.TabIndex = 1;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(392, 191);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(40, 13);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "UserID";
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Location = new System.Drawing.Point(392, 191);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(40, 13);
            this.UserIDLabel.TabIndex = 2;
            this.UserIDLabel.Text = "UserID";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(548, 192);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(548, 252);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(129, 46);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(392, 251);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(129, 46);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(945, 466);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(129, 46);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserIDLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.UserField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Utility Tool - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox UserField;
        public System.Windows.Forms.MaskedTextBox PasswordField;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}