
namespace time_management_system
{
    partial class Form1
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
            this.btn_click_me = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_click_me
            // 
            this.btn_click_me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_click_me.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_click_me.Location = new System.Drawing.Point(350, 200);
            this.btn_click_me.Name = "btn_click_me";
            this.btn_click_me.Size = new System.Drawing.Size(100, 30);
            this.btn_click_me.TabIndex = 0;
            this.btn_click_me.Text = "Click me";
            this.btn_click_me.UseVisualStyleBackColor = false;
            this.btn_click_me.Click += new System.EventHandler(this.btn_click_me_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_click_me);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_click_me;
    }
}

