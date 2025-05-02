namespace Register
{
    partial class FormDaftar
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtKonfirmasiPassword;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblKonfirmasi;

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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtKonfirmasiPassword = new TextBox();
            btnDaftar = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            lblKonfirmasi = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(30, 40);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 90);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 31);
            txtPassword.TabIndex = 3;
            // 
            // txtKonfirmasiPassword
            // 
            txtKonfirmasiPassword.Location = new Point(30, 140);
            txtKonfirmasiPassword.Name = "txtKonfirmasiPassword";
            txtKonfirmasiPassword.PasswordChar = '*';
            txtKonfirmasiPassword.Size = new Size(200, 31);
            txtKonfirmasiPassword.TabIndex = 5;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(30, 180);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(200, 30);
            btnDaftar.TabIndex = 6;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = true;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(30, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(200, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(30, 70);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(200, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblKonfirmasi
            // 
            lblKonfirmasi.Location = new Point(30, 120);
            lblKonfirmasi.Name = "lblKonfirmasi";
            lblKonfirmasi.Size = new Size(200, 15);
            lblKonfirmasi.TabIndex = 4;
            lblKonfirmasi.Text = "Konfirmasi Password";
            // 
            // FormDaftar
            // 
            ClientSize = new Size(274, 226);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblKonfirmasi);
            Controls.Add(txtKonfirmasiPassword);
            Controls.Add(btnDaftar);
            Name = "FormDaftar";
            Text = "Daftar Akun Baru";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
