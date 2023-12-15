namespace ProjekUTS_CapKakiTiga
{
    partial class FormHasilPeriksa
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
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHasil = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.BackColor = System.Drawing.Color.SteelBlue;
            this.labelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.Color.White;
            this.labelBack.Location = new System.Drawing.Point(13, 10);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(38, 40);
            this.labelBack.TabIndex = 7;
            this.labelBack.Text = "<";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.Color.SteelBlue;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelJudul.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelJudul.Location = new System.Drawing.Point(-1, -1);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(900, 69);
            this.labelJudul.TabIndex = 6;
            this.labelJudul.Text = "Check Up Result";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(65, 101);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(64, 25);
            this.labelTanggal.TabIndex = 10;
            this.labelTanggal.Text = "Date :";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(508, 101);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(85, 25);
            this.labelNama.TabIndex = 11;
            this.labelNama.Text = "Doctor : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Result :";
            // 
            // textBoxHasil
            // 
            this.textBoxHasil.Location = new System.Drawing.Point(70, 195);
            this.textBoxHasil.Multiline = true;
            this.textBoxHasil.Name = "textBoxHasil";
            this.textBoxHasil.Size = new System.Drawing.Size(758, 227);
            this.textBoxHasil.TabIndex = 13;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(646, 446);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(182, 49);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(70, 446);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(209, 49);
            this.buttonPrint.TabIndex = 18;
            this.buttonPrint.Text = "Save to PDF";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // FormHasilPeriksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 512);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxHasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.labelJudul);
            this.Name = "FormHasilPeriksa";
            this.Text = "CheckUp";
            this.Load += new System.EventHandler(this.FormHasilPeriksa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHasil;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPrint;
    }
}