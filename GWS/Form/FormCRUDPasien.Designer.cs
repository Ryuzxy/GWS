namespace PasienS.Forms
{
    partial class FormPasiens
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.ComboBox cmbJenisKelamin;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelTanggalLahir;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelJenisKelamin;
        private System.Windows.Forms.Label labelTelepon;

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
            dataGridView1 = new DataGridView();
            txtNama = new TextBox();
            dtpTanggalLahir = new DateTimePicker();
            txtAlamat = new TextBox();
            cmbJenisKelamin = new ComboBox();
            txtTelepon = new TextBox();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            labelNama = new Label();
            labelTanggalLahir = new Label();
            labelAlamat = new Label();
            labelJenisKelamin = new Label();
            labelTelepon = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(43, 417);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(714, 333);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(214, 28);
            txtNama.Margin = new Padding(4, 5, 4, 5);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(284, 31);
            txtNama.TabIndex = 1;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Location = new Point(214, 87);
            dtpTanggalLahir.Margin = new Padding(4, 5, 4, 5);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(284, 31);
            dtpTanggalLahir.TabIndex = 2;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(214, 145);
            txtAlamat.Margin = new Padding(4, 5, 4, 5);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(284, 31);
            txtAlamat.TabIndex = 3;
            // 
            // cmbJenisKelamin
            // 
            cmbJenisKelamin.Items.AddRange(new object[] { "Laki-laki", "Perempuan" });
            cmbJenisKelamin.Location = new Point(214, 203);
            cmbJenisKelamin.Margin = new Padding(4, 5, 4, 5);
            cmbJenisKelamin.Name = "cmbJenisKelamin";
            cmbJenisKelamin.Size = new Size(284, 33);
            cmbJenisKelamin.TabIndex = 4;
            // 
            // txtTelepon
            // 
            txtTelepon.Location = new Point(214, 262);
            txtTelepon.Margin = new Padding(4, 5, 4, 5);
            txtTelepon.Name = "txtTelepon";
            txtTelepon.Size = new Size(284, 31);
            txtTelepon.TabIndex = 5;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(43, 333);
            btnTambah.Margin = new Padding(4, 5, 4, 5);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(143, 50);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Tambah";
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(200, 333);
            btnUbah.Margin = new Padding(4, 5, 4, 5);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(143, 50);
            btnUbah.TabIndex = 7;
            btnUbah.Text = "Ubah";
            btnUbah.Click += btnUbah_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(357, 333);
            btnHapus.Margin = new Padding(4, 5, 4, 5);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(143, 50);
            btnHapus.TabIndex = 8;
            btnHapus.Text = "Hapus";
            btnHapus.Click += btnHapus_Click;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(43, 33);
            labelNama.Margin = new Padding(4, 0, 4, 0);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(59, 25);
            labelNama.TabIndex = 9;
            labelNama.Text = "Nama";
            // 
            // labelTanggalLahir
            // 
            labelTanggalLahir.AutoSize = true;
            labelTanggalLahir.Location = new Point(43, 92);
            labelTanggalLahir.Margin = new Padding(4, 0, 4, 0);
            labelTanggalLahir.Name = "labelTanggalLahir";
            labelTanggalLahir.Size = new Size(115, 25);
            labelTanggalLahir.TabIndex = 10;
            labelTanggalLahir.Text = "Tanggal Lahir";
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Location = new Point(43, 150);
            labelAlamat.Margin = new Padding(4, 0, 4, 0);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(68, 25);
            labelAlamat.TabIndex = 11;
            labelAlamat.Text = "Alamat";
            // 
            // labelJenisKelamin
            // 
            labelJenisKelamin.AutoSize = true;
            labelJenisKelamin.Location = new Point(43, 208);
            labelJenisKelamin.Margin = new Padding(4, 0, 4, 0);
            labelJenisKelamin.Name = "labelJenisKelamin";
            labelJenisKelamin.Size = new Size(116, 25);
            labelJenisKelamin.TabIndex = 12;
            labelJenisKelamin.Text = "Jenis Kelamin";
            // 
            // labelTelepon
            // 
            labelTelepon.AutoSize = true;
            labelTelepon.Location = new Point(43, 267);
            labelTelepon.Margin = new Padding(4, 0, 4, 0);
            labelTelepon.Name = "labelTelepon";
            labelTelepon.Size = new Size(73, 25);
            labelTelepon.TabIndex = 13;
            labelTelepon.Text = "Telepon";
            // 
            // FormPasiens
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 800);
            Controls.Add(dataGridView1);
            Controls.Add(txtNama);
            Controls.Add(dtpTanggalLahir);
            Controls.Add(txtAlamat);
            Controls.Add(cmbJenisKelamin);
            Controls.Add(txtTelepon);
            Controls.Add(btnTambah);
            Controls.Add(btnUbah);
            Controls.Add(btnHapus);
            Controls.Add(labelNama);
            Controls.Add(labelTanggalLahir);
            Controls.Add(labelAlamat);
            Controls.Add(labelJenisKelamin);
            Controls.Add(labelTelepon);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPasiens";
            Text = "Manajemen Pasien";
            Load += FormPasiens_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
