namespace DokterForm.Forms
{
    partial class FormDokter
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtSpesialis;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelSpesialis;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;

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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtSpesialis = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelSpesialis = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // labelNama
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(30, 20);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(39, 15);
            this.labelNama.Text = "Nama";

            // txtNama
            this.txtNama.Location = new System.Drawing.Point(150, 17);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 23);

            // labelSpesialis
            this.labelSpesialis.AutoSize = true;
            this.labelSpesialis.Location = new System.Drawing.Point(30, 55);
            this.labelSpesialis.Name = "labelSpesialis";
            this.labelSpesialis.Size = new System.Drawing.Size(53, 15);
            this.labelSpesialis.Text = "Spesialis";

            // txtSpesialis
            this.txtSpesialis.Location = new System.Drawing.Point(150, 52);
            this.txtSpesialis.Name = "txtSpesialis";
            this.txtSpesialis.Size = new System.Drawing.Size(200, 23);

            // labelUsername
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(30, 90);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(60, 15);
            this.labelUsername.Text = "Username";

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(150, 87);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 23);

            // labelPassword
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(30, 125);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.Text = "Password";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(150, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.PasswordChar = '*';

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

            // FormDokter
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtSpesialis);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelSpesialis);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPassword);
            this.Name = "FormDokter";
            this.Text = "Manajemen Dokter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
