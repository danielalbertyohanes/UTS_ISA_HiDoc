namespace ProjekUTS_CapKakiTiga
{
    partial class FormJanjiTemuPasien
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
            this.labelBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTanggalJanjiTemu = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerWaktuJanjiTemu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDokter = new System.Windows.Forms.ComboBox();
            this.buttonAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.BackColor = System.Drawing.Color.SteelBlue;
            this.labelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.Color.White;
            this.labelBack.Location = new System.Drawing.Point(15, 11);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(38, 40);
            this.labelBack.TabIndex = 8;
            this.labelBack.Text = "<";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "Make Appointment with Doctor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date and Time";
            // 
            // dateTimePickerTanggalJanjiTemu
            // 
            this.dateTimePickerTanggalJanjiTemu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTanggalJanjiTemu.Location = new System.Drawing.Point(93, 126);
            this.dateTimePickerTanggalJanjiTemu.Name = "dateTimePickerTanggalJanjiTemu";
            this.dateTimePickerTanggalJanjiTemu.Size = new System.Drawing.Size(246, 32);
            this.dateTimePickerTanggalJanjiTemu.TabIndex = 19;
            this.dateTimePickerTanggalJanjiTemu.Value = new System.DateTime(2023, 5, 9, 0, 0, 0, 0);
            // 
            // dateTimePickerWaktuJanjiTemu
            // 
            this.dateTimePickerWaktuJanjiTemu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerWaktuJanjiTemu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerWaktuJanjiTemu.Location = new System.Drawing.Point(360, 126);
            this.dateTimePickerWaktuJanjiTemu.Name = "dateTimePickerWaktuJanjiTemu";
            this.dateTimePickerWaktuJanjiTemu.ShowUpDown = true;
            this.dateTimePickerWaktuJanjiTemu.Size = new System.Drawing.Size(119, 32);
            this.dateTimePickerWaktuJanjiTemu.TabIndex = 20;
            this.dateTimePickerWaktuJanjiTemu.Value = new System.DateTime(2023, 5, 9, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Doctor";
            // 
            // comboBoxDokter
            // 
            this.comboBoxDokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDokter.FormattingEnabled = true;
            this.comboBoxDokter.Location = new System.Drawing.Point(93, 216);
            this.comboBoxDokter.Name = "comboBoxDokter";
            this.comboBoxDokter.Size = new System.Drawing.Size(246, 34);
            this.comboBoxDokter.TabIndex = 22;
            // 
            // buttonAppointment
            // 
            this.buttonAppointment.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointment.ForeColor = System.Drawing.Color.White;
            this.buttonAppointment.Location = new System.Drawing.Point(93, 278);
            this.buttonAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAppointment.Name = "buttonAppointment";
            this.buttonAppointment.Size = new System.Drawing.Size(386, 49);
            this.buttonAppointment.TabIndex = 23;
            this.buttonAppointment.Text = "Make Appointment";
            this.buttonAppointment.UseVisualStyleBackColor = false;
            this.buttonAppointment.Click += new System.EventHandler(this.buttonAppointment_Click);
            // 
            // FormJanjiTemuPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 359);
            this.Controls.Add(this.buttonAppointment);
            this.Controls.Add(this.comboBoxDokter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerWaktuJanjiTemu);
            this.Controls.Add(this.dateTimePickerTanggalJanjiTemu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormJanjiTemuPasien";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.FormJanjiTemuPasien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalJanjiTemu;
        private System.Windows.Forms.DateTimePicker dateTimePickerWaktuJanjiTemu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDokter;
        private System.Windows.Forms.Button buttonAppointment;
    }
}