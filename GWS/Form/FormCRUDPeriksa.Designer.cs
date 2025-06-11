namespace GWS.Forms
{
    partial class FormPeriksa
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPeriksa;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;

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
            this.dgvPeriksa = new System.Windows.Forms.DataGridView();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriksa)).BeginInit();
            this.SuspendLayout();

            // dgvPeriksa
            this.dgvPeriksa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriksa.Location = new System.Drawing.Point(20, 160);
            this.dgvPeriksa.Name = "dgvPeriksa";
            this.dgvPeriksa.RowTemplate.Height = 25;
            this.dgvPeriksa.Size = new System.Drawing.Size(500, 200);
            this.dgvPeriksa.TabIndex = 0;

            // lblNama
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(20, 20);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(96, 15);
            this.lblNama.Text = "Nama Pemeriksaan";

            // txtNama
            this.txtNama.Location = new System.Drawing.Point(150, 17);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 23);
            this.txtNama.TabIndex = 1;

            // lblDeskripsi
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(20, 55);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(54, 15);
            this.lblDeskripsi.Text = "Deskripsi";

            // txtDeskripsi
            this.txtDeskripsi.Location = new System.Drawing.Point(150, 52);
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(200, 23);
            this.txtDeskripsi.TabIndex = 2;

            // btnTambah
            this.btnTambah.Location = new System.Drawing.Point(20, 100);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 30);
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            // btnUbah
            this.btnUbah.Location = new System.Drawing.Point(130, 100);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(100, 30);
            this.btnUbah.Text = "Ubah";
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);

            // btnHapus
            this.btnHapus.Location = new System.Drawing.Point(240, 100);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 30);
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            // FormPeriksa
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.dgvPeriksa);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnHapus);
            this.Name = "FormPeriksa";
            this.Text = "Manajemen Pemeriksaan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriksa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
