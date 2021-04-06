
namespace Zeitmanagement_System
{
    partial class Window_login
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
            this.btn_login = new System.Windows.Forms.Button();
            this._credentials = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_login.Location = new System.Drawing.Point(119, 104);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "login";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // _credentials
            // 
            this._credentials.Location = new System.Drawing.Point(54, 35);
            this._credentials.Name = "_credentials";
            this._credentials.Size = new System.Drawing.Size(196, 23);
            this._credentials.TabIndex = 1;
            this._credentials.Text = "kurzzeichen";
            this._credentials.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(54, 64);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(196, 23);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.Text = "passwort";
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Window_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(311, 158);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this._credentials);
            this.Controls.Add(this.btn_login);
            this.Name = "Window_login";
            this.Text = "Login Required";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox _credentials;
        private System.Windows.Forms.TextBox textBox_password;
    }
}

