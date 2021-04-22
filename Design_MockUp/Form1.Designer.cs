
namespace Design_MockUp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelKommen = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelGehen = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonKrank = new System.Windows.Forms.RadioButton();
            this.radioButtonUrlaub = new System.Windows.Forms.RadioButton();
            this.radioButtonZeitausgleich = new System.Windows.Forms.RadioButton();
            this.groupBoxMitarbeiter = new System.Windows.Forms.GroupBox();
            this.radioButtonArbeitend = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timePickerGehen = new System.Windows.Forms.DateTimePicker();
            this.timePickerKommen = new System.Windows.Forms.DateTimePicker();
            this.labelProjektCaption = new System.Windows.Forms.Label();
            this.groupBoxMitarbeiter.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2586, -906);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 31);
            this.textBox1.TabIndex = 1;
            // 
            // labelKommen
            // 
            this.labelKommen.AutoSize = true;
            this.labelKommen.Location = new System.Drawing.Point(28, 57);
            this.labelKommen.Name = "labelKommen";
            this.labelKommen.Size = new System.Drawing.Size(84, 25);
            this.labelKommen.TabIndex = 2;
            this.labelKommen.Text = "Kommen";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(2657, -864);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(507, 31);
            this.textBox2.TabIndex = 5;
            // 
            // labelGehen
            // 
            this.labelGehen.AutoSize = true;
            this.labelGehen.Location = new System.Drawing.Point(28, 124);
            this.labelGehen.Name = "labelGehen";
            this.labelGehen.Size = new System.Drawing.Size(62, 25);
            this.labelGehen.TabIndex = 10;
            this.labelGehen.Text = "Gehen";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(38, 153);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 45);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mitarbeiter Ansicht";
            // 
            // radioButtonKrank
            // 
            this.radioButtonKrank.AutoSize = true;
            this.radioButtonKrank.Location = new System.Drawing.Point(248, 85);
            this.radioButtonKrank.Name = "radioButtonKrank";
            this.radioButtonKrank.Size = new System.Drawing.Size(81, 29);
            this.radioButtonKrank.TabIndex = 15;
            this.radioButtonKrank.Text = "Krank";
            this.radioButtonKrank.UseVisualStyleBackColor = true;
            // 
            // radioButtonUrlaub
            // 
            this.radioButtonUrlaub.AutoSize = true;
            this.radioButtonUrlaub.Location = new System.Drawing.Point(248, 120);
            this.radioButtonUrlaub.Name = "radioButtonUrlaub";
            this.radioButtonUrlaub.Size = new System.Drawing.Size(89, 29);
            this.radioButtonUrlaub.TabIndex = 16;
            this.radioButtonUrlaub.Text = "Urlaub";
            this.radioButtonUrlaub.UseVisualStyleBackColor = true;
            // 
            // radioButtonZeitausgleich
            // 
            this.radioButtonZeitausgleich.AutoSize = true;
            this.radioButtonZeitausgleich.Location = new System.Drawing.Point(248, 155);
            this.radioButtonZeitausgleich.Name = "radioButtonZeitausgleich";
            this.radioButtonZeitausgleich.Size = new System.Drawing.Size(139, 29);
            this.radioButtonZeitausgleich.TabIndex = 17;
            this.radioButtonZeitausgleich.Text = "Zeitausgleich";
            this.radioButtonZeitausgleich.UseVisualStyleBackColor = true;
            // 
            // groupBoxMitarbeiter
            // 
            this.groupBoxMitarbeiter.Controls.Add(this.labelProjektCaption);
            this.groupBoxMitarbeiter.Controls.Add(this.radioButtonArbeitend);
            this.groupBoxMitarbeiter.Controls.Add(this.button2);
            this.groupBoxMitarbeiter.Controls.Add(this.button1);
            this.groupBoxMitarbeiter.Controls.Add(this.listBox1);
            this.groupBoxMitarbeiter.Controls.Add(this.timePickerGehen);
            this.groupBoxMitarbeiter.Controls.Add(this.timePickerKommen);
            this.groupBoxMitarbeiter.Controls.Add(this.labelGehen);
            this.groupBoxMitarbeiter.Controls.Add(this.radioButtonUrlaub);
            this.groupBoxMitarbeiter.Controls.Add(this.radioButtonKrank);
            this.groupBoxMitarbeiter.Controls.Add(this.radioButtonZeitausgleich);
            this.groupBoxMitarbeiter.Controls.Add(this.labelKommen);
            this.groupBoxMitarbeiter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxMitarbeiter.Location = new System.Drawing.Point(292, 141);
            this.groupBoxMitarbeiter.Name = "groupBoxMitarbeiter";
            this.groupBoxMitarbeiter.Size = new System.Drawing.Size(430, 436);
            this.groupBoxMitarbeiter.TabIndex = 18;
            this.groupBoxMitarbeiter.TabStop = false;
            this.groupBoxMitarbeiter.Text = "groupBox1";
            // 
            // radioButtonArbeitend
            // 
            this.radioButtonArbeitend.AutoSize = true;
            this.radioButtonArbeitend.Checked = true;
            this.radioButtonArbeitend.Location = new System.Drawing.Point(248, 50);
            this.radioButtonArbeitend.Name = "radioButtonArbeitend";
            this.radioButtonArbeitend.Size = new System.Drawing.Size(115, 29);
            this.radioButtonArbeitend.TabIndex = 25;
            this.radioButtonArbeitend.TabStop = true;
            this.radioButtonArbeitend.Text = "Arbeitend";
            this.radioButtonArbeitend.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 24;
            this.button2.Text = "Löschen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "Zuteilen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(28, 247);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(375, 79);
            this.listBox1.TabIndex = 22;
            // 
            // timePickerGehen
            // 
            this.timePickerGehen.CustomFormat = "HH\':00Uhr\'";
            this.timePickerGehen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerGehen.Location = new System.Drawing.Point(32, 152);
            this.timePickerGehen.Name = "timePickerGehen";
            this.timePickerGehen.ShowUpDown = true;
            this.timePickerGehen.Size = new System.Drawing.Size(134, 31);
            this.timePickerGehen.TabIndex = 21;
            this.timePickerGehen.Value = new System.DateTime(2000, 1, 1, 16, 0, 0, 0);
            // 
            // timePickerKommen
            // 
            this.timePickerKommen.CustomFormat = "HH\':00Uhr\'";
            this.timePickerKommen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerKommen.Location = new System.Drawing.Point(32, 85);
            this.timePickerKommen.Name = "timePickerKommen";
            this.timePickerKommen.ShowUpDown = true;
            this.timePickerKommen.Size = new System.Drawing.Size(134, 31);
            this.timePickerKommen.TabIndex = 20;
            this.timePickerKommen.Value = new System.DateTime(2000, 1, 1, 8, 0, 0, 0);
            // 
            // labelProjektCaption
            // 
            this.labelProjektCaption.AutoSize = true;
            this.labelProjektCaption.Location = new System.Drawing.Point(22, 219);
            this.labelProjektCaption.Name = "labelProjektCaption";
            this.labelProjektCaption.Size = new System.Drawing.Size(118, 25);
            this.labelProjektCaption.TabIndex = 19;
            this.labelProjektCaption.Text = "Project listing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 912);
            this.Controls.Add(this.groupBoxMitarbeiter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMitarbeiter.ResumeLayout(false);
            this.groupBoxMitarbeiter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelKommen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelGehen;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonKrank;
        private System.Windows.Forms.RadioButton radioButtonUrlaub;
        private System.Windows.Forms.RadioButton radioButtonZeitausgleich;
        private System.Windows.Forms.GroupBox groupBoxMitarbeiter;
        private System.Windows.Forms.DateTimePicker timePickerKommen;
        private System.Windows.Forms.DateTimePicker timePickerGehen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButtonArbeitend;
        private System.Windows.Forms.Label labelProjektCaption;
    }
}

