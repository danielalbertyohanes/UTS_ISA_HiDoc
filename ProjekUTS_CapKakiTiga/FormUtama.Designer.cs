namespace ProjekUTS_CapKakiTiga
{
    partial class FormUtama
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
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahDokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pasienToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.janjiTemuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatPemeriksaaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JanjiTemuDokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayPatientsDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(230, 255);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(132, 29);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "user name!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hello, ";
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(56, 28);
            this.keluarToolStripMenuItem.Text = "Exit";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // tambahDokterToolStripMenuItem
            // 
            this.tambahDokterToolStripMenuItem.Name = "tambahDokterToolStripMenuItem";
            this.tambahDokterToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.tambahDokterToolStripMenuItem.Text = "Add Doctor";
            this.tambahDokterToolStripMenuItem.Click += new System.EventHandler(this.tambahDokterToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahDokterToolStripMenuItem,
            this.displayDoctorsToolStripMenuItem,
            this.displayPatientsDataToolStripMenuItem});
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(76, 32);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(77, 28);
            this.profilToolStripMenuItem.Text = "Profile";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasienToolStripMenuItem1,
            this.profilToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.dokterToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pasienToolStripMenuItem1
            // 
            this.pasienToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.janjiTemuToolStripMenuItem,
            this.riwayatPemeriksaaanToolStripMenuItem});
            this.pasienToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasienToolStripMenuItem1.Name = "pasienToolStripMenuItem1";
            this.pasienToolStripMenuItem1.Size = new System.Drawing.Size(82, 28);
            this.pasienToolStripMenuItem1.Text = "Patient";
            // 
            // janjiTemuToolStripMenuItem
            // 
            this.janjiTemuToolStripMenuItem.Name = "janjiTemuToolStripMenuItem";
            this.janjiTemuToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.janjiTemuToolStripMenuItem.Text = "Make Appointment";
            this.janjiTemuToolStripMenuItem.Click += new System.EventHandler(this.janjiTemuToolStripMenuItem_Click);
            // 
            // riwayatPemeriksaaanToolStripMenuItem
            // 
            this.riwayatPemeriksaaanToolStripMenuItem.Name = "riwayatPemeriksaaanToolStripMenuItem";
            this.riwayatPemeriksaaanToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.riwayatPemeriksaaanToolStripMenuItem.Text = "Check Up History";
            this.riwayatPemeriksaaanToolStripMenuItem.Click += new System.EventHandler(this.riwayatPemeriksaaanToolStripMenuItem_Click);
            // 
            // dokterToolStripMenuItem
            // 
            this.dokterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JanjiTemuDokterToolStripMenuItem});
            this.dokterToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dokterToolStripMenuItem.Name = "dokterToolStripMenuItem";
            this.dokterToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.dokterToolStripMenuItem.Text = "Doctor";
            // 
            // JanjiTemuDokterToolStripMenuItem
            // 
            this.JanjiTemuDokterToolStripMenuItem.Name = "JanjiTemuDokterToolStripMenuItem";
            this.JanjiTemuDokterToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.JanjiTemuDokterToolStripMenuItem.Text = "Patients Appointment";
            this.JanjiTemuDokterToolStripMenuItem.Click += new System.EventHandler(this.JanjiTemuDokterToolStripMenuItem_Click);
            // 
            // displayDoctorsToolStripMenuItem
            // 
            this.displayDoctorsToolStripMenuItem.Name = "displayDoctorsToolStripMenuItem";
            this.displayDoctorsToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.displayDoctorsToolStripMenuItem.Text = "Display Doctors Data";
            this.displayDoctorsToolStripMenuItem.Click += new System.EventHandler(this.displayDoctorsToolStripMenuItem_Click);
            // 
            // displayPatientsDataToolStripMenuItem
            // 
            this.displayPatientsDataToolStripMenuItem.Name = "displayPatientsDataToolStripMenuItem";
            this.displayPatientsDataToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.displayPatientsDataToolStripMenuItem.Text = "Display Patients Data";
            this.displayPatientsDataToolStripMenuItem.Click += new System.EventHandler(this.displayPatientsDataToolStripMenuItem_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 619);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUtama";
            this.Text = "HiDoc";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahDokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JanjiTemuDokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasienToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem riwayatPemeriksaaanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janjiTemuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayPatientsDataToolStripMenuItem;
    }
}