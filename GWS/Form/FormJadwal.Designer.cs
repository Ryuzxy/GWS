namespace JadwalForm.Forms
{
    partial class FormJadwal : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDokterId;
        private System.Windows.Forms.TextBox txtHari;
        private System.Windows.Forms.TextBox txtJamMulai;
        private System.Windows.Forms.TextBox txtJamSelesai;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label labelDokterId;
        private System.Windows.Forms.Label labelHari;
        private System.Windows.Forms.Label labelJamMulai;
        private System.Windows.Forms.Label labelJamSelesai;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDokterId = new System.Windows.Forms.TextBox();
            this.txtHari = new System.Windows.Forms.TextBox();
            this.txtJamMulai = new System.Windows.Forms.TextBox();
            this.txtJamSelesai = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.labelDokterId = new System.Windows.Forms.Label();
            this.labelHari = new System.Windows.Forms.Label();
            this.labelJamMulai = new System.Windows.Forms.Label();
            this.labelJamSelesai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // labelDokterId
            this.labelDokterId.AutoSize = true;
            this.labelDokterId.Location = new System.Drawing.Point(30, 20);
            this.labelDokterId.Name = "labelDokterId";
            this.labelDokterId.Size = new System.Drawing.Size(59, 15);
            this.labelDokterId.Text = "Dokter ID";

            // txtDokterId
            this.txtDokterId.Location = new System.Drawing.Point(150, 17);
            this.txtDokterId.Name = "txtDokterId";
            this.txtDokterId.Size = new System.Drawing.Size(200, 23);

            // labelHari
            this.labelHari.AutoSize = true;
            this.labelHari.Location = new System.Drawing.Point(30, 55);
            this.labelHari.Name = "labelHari";
            this.labelHari.Size = new System.Drawing.Size(29, 15);
            this.labelHari.Text = "Hari";

            // txtHari
            this.txtHari.Location = new System.Drawing.Point(150, 52);
            this.txtHari.Name = "txtHari";
            this.txtHari.Size = new System.Drawing.Size(200, 23);

            // labelJamMulai
            this.labelJamMulai.AutoSize = true;
            this.labelJamMulai.Location = new System.Drawing.Point(30, 90);
            this.labelJamMulai.Name = "labelJamMulai";
            this.labelJamMulai.Size = new System.Drawing.Size(63, 15);
            this.labelJamMulai.Text = "Jam Mulai";

            // txtJamMulai
            this.txtJamMulai.Location = new System.Drawing.Point(150, 87);
            this.txtJamMulai.Name = "txtJamMulai";
            this.txtJamMulai.Size = new System.Drawing.Size(200, 23);

            // labelJamSelesai
            this.labelJamSelesai.AutoSize = true;
            this.labelJamSelesai.Location = new System.Drawing.Point(30, 125);
            this.labelJamSelesai.Name = "labelJamSelesai";
            this.labelJamSelesai.Size = new System.Drawing.Size(72, 15);
            this.labelJamSelesai.Text = "Jam Selesai";

            // txtJamSelesai
            this.txtJamSelesai.Location = new System.Drawing.Point(150, 122);
            this.txtJamSelesai.Name = "txtJamSelesai";
            this.txtJamSelesai.Size = new System.Drawing.Size(200, 23);

            // btnTambah
            this.btnTambah.Location = new System.Drawing.Point(30, 160);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 30);
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            // btnUbah
            this.btnUbah.Location = new System.Drawing.Point(140, 160);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(100, 30);
            this.btnUbah.Text = "Ubah";
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);

            // btnHapus
            this.btnHapus.Location = new System.Drawing.Point(250, 160);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 30);
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            // dataGridView1
            this.dataGridView1.Location = new System.Drawing.Point(30, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 200);

            // FormJadwal
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDokterId);
            this.Controls.Add(this.txtHari);
            this.Controls.Add(this.txtJamMulai);
            this.Controls.Add(this.txtJamSelesai);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.labelDokterId);
            this.Controls.Add(this.labelHari);
            this.Controls.Add(this.labelJamMulai);
            this.Controls.Add(this.labelJamSelesai);
            this.Name = "FormJadwal";
            this.Text = "Manajemen Jadwal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
