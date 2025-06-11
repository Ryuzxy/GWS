namespace GWS.Forms
{
    partial class FormObat
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblKeterangan;

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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblKeterangan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // Label Nama
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(30, 20);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(39, 15);
            this.lblNama.Text = "Nama";

            // TextBox Nama
            this.txtNama.Location = new System.Drawing.Point(120, 17);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 23);

            // Label Stok
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(30, 55);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(32, 15);
            this.lblStok.Text = "Stok";

            // TextBox Stok
            this.txtStok.Location = new System.Drawing.Point(120, 52);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(200, 23);

            // Label Keterangan
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Location = new System.Drawing.Point(30, 90);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(67, 15);
            this.lblKeterangan.Text = "Keterangan";

            // TextBox Keterangan
            this.txtKeterangan.Location = new System.Drawing.Point(120, 87);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(200, 23);

            // Button Tambah
            this.btnTambah.Location = new System.Drawing.Point(30, 130);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(90, 30);
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            // Button Ubah
            this.btnUbah.Location = new System.Drawing.Point(130, 130);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(90, 30);
            this.btnUbah.Text = "Ubah";
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);

            // Button Hapus
            this.btnHapus.Location = new System.Drawing.Point(230, 130);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(90, 30);
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(30, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 200);

            // FormObat
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 400);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormObat";
            this.Text = "Manajemen Obat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
