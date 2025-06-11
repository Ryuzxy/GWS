namespace GWS.Form
{
    partial class FormAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnPasien;
        private System.Windows.Forms.Button btnDokter;
        private System.Windows.Forms.Button btnJadwal;
        private System.Windows.Forms.Button btnPeriksa;
        private System.Windows.Forms.Button btnObat;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnPasien = new System.Windows.Forms.Button();
            this.btnDokter = new System.Windows.Forms.Button();
            this.btnJadwal = new System.Windows.Forms.Button();
            this.btnPeriksa = new System.Windows.Forms.Button();
            this.btnObat = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            // 
            // btnPasien
            // 
            this.btnPasien.Location = new System.Drawing.Point(30, 30);
            this.btnPasien.Name = "btnPasien";
            this.btnPasien.Size = new System.Drawing.Size(150, 40);
            this.btnPasien.Text = "Kelola Pasien";
            this.btnPasien.Click += new System.EventHandler(this.btnPasien_Click);

            // 
            // btnDokter
            // 
            this.btnDokter.Location = new System.Drawing.Point(30, 80);
            this.btnDokter.Name = "btnDokter";
            this.btnDokter.Size = new System.Drawing.Size(150, 40);
            this.btnDokter.Text = "Kelola Dokter";
            this.btnDokter.Click += new System.EventHandler(this.btnDokter_Click);

            // 
            // btnJadwal
            // 
            this.btnJadwal.Location = new System.Drawing.Point(30, 130);
            this.btnJadwal.Name = "btnJadwal";
            this.btnJadwal.Size = new System.Drawing.Size(150, 40);
            this.btnJadwal.Text = "Kelola Jadwal";
            this.btnJadwal.Click += new System.EventHandler(this.btnJadwal_Click);

            // 
            // btnPeriksa
            // 
            this.btnPeriksa.Location = new System.Drawing.Point(30, 180);
            this.btnPeriksa.Name = "btnPeriksa";
            this.btnPeriksa.Size = new System.Drawing.Size(150, 40);
            this.btnPeriksa.Text = "Kelola Periksa";
            this.btnPeriksa.Click += new System.EventHandler(this.btnPeriksa_Click);

            // 
            // btnObat
            // 
            this.btnObat.Location = new System.Drawing.Point(30, 230);
            this.btnObat.Name = "btnObat";
            this.btnObat.Size = new System.Drawing.Size(150, 40);
            this.btnObat.Text = "Kelola Obat";
            this.btnObat.Click += new System.EventHandler(this.btnObat_Click);

            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(30, 280);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 40);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // 
            // FormAdmin
            // 
            this.ClientSize = new System.Drawing.Size(220, 350);
            this.Controls.Add(this.btnPasien);
            this.Controls.Add(this.btnDokter);
            this.Controls.Add(this.btnJadwal);
            this.Controls.Add(this.btnPeriksa);
            this.Controls.Add(this.btnObat);
            this.Controls.Add(this.btnLogout);
            this.Name = "FormAdmin";
            this.Text = "Menu Admin";
        }
    }
}
