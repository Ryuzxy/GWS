namespace DokterForm.Forms
{
    partial class FormCRUDDokter
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
            dataGridView1 = new DataGridView();
            txtNama = new TextBox();
            txtSpesialis = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            labelNama = new Label();
            labelSpesialis = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(43, 350);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(714, 333);
            dataGridView1.TabIndex = 0;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(214, 28);
            txtNama.Margin = new Padding(4, 5, 4, 5);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(284, 31);
            txtNama.TabIndex = 1;
            // 
            // txtSpesialis
            // 
            txtSpesialis.Location = new Point(214, 87);
            txtSpesialis.Margin = new Padding(4, 5, 4, 5);
            txtSpesialis.Name = "txtSpesialis";
            txtSpesialis.Size = new Size(284, 31);
            txtSpesialis.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(214, 145);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(284, 31);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(214, 203);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(284, 31);
            txtPassword.TabIndex = 4;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(43, 267);
            btnTambah.Margin = new Padding(4, 5, 4, 5);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(143, 50);
            btnTambah.TabIndex = 5;
            btnTambah.Text = "Tambah";
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(200, 267);
            btnUbah.Margin = new Padding(4, 5, 4, 5);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(143, 50);
            btnUbah.TabIndex = 6;
            btnUbah.Text = "Ubah";
            btnUbah.Click += btnUbah_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(357, 267);
            btnHapus.Margin = new Padding(4, 5, 4, 5);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(143, 50);
            btnHapus.TabIndex = 7;
            btnHapus.Text = "Hapus";
            btnHapus.Click += btnHapus_Click;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Location = new Point(43, 33);
            labelNama.Margin = new Padding(4, 0, 4, 0);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(59, 25);
            labelNama.TabIndex = 8;
            labelNama.Text = "Nama";
            // 
            // labelSpesialis
            // 
            labelSpesialis.AutoSize = true;
            labelSpesialis.BackColor = Color.Transparent;
            labelSpesialis.Location = new Point(43, 92);
            labelSpesialis.Margin = new Padding(4, 0, 4, 0);
            labelSpesialis.Name = "labelSpesialis";
            labelSpesialis.Size = new Size(79, 25);
            labelSpesialis.TabIndex = 9;
            labelSpesialis.Text = "Spesialis";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.Location = new Point(43, 150);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(91, 25);
            labelUsername.TabIndex = 10;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Location = new Point(43, 208);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(87, 25);
            labelPassword.TabIndex = 11;
            labelPassword.Text = "Password";
            // 
            // FormDokter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(796, 750);
            Controls.Add(dataGridView1);
            Controls.Add(txtNama);
            Controls.Add(txtSpesialis);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnTambah);
            Controls.Add(btnUbah);
            Controls.Add(btnHapus);
            Controls.Add(labelNama);
            Controls.Add(labelSpesialis);
            Controls.Add(labelUsername);
            Controls.Add(labelPassword);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormDokter";
            Text = "Manajemen Dokter";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
