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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftar));
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
            txtUsername.BackColor = SystemColors.InactiveCaption;
            txtUsername.Location = new Point(30, 31);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.InactiveCaption;
            txtPassword.Location = new Point(30, 99);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 31);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtKonfirmasiPassword
            // 
            txtKonfirmasiPassword.BackColor = SystemColors.InactiveCaption;
            txtKonfirmasiPassword.Location = new Point(30, 170);
            txtKonfirmasiPassword.Name = "txtKonfirmasiPassword";
            txtKonfirmasiPassword.PasswordChar = '*';
            txtKonfirmasiPassword.Size = new Size(200, 31);
            txtKonfirmasiPassword.TabIndex = 5;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.Transparent;
            btnDaftar.BackgroundImage = (Image)resources.GetObject("btnDaftar.BackgroundImage");
            btnDaftar.Location = new Point(30, 228);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(200, 34);
            btnDaftar.TabIndex = 6;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Location = new Point(30, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(200, 28);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Location = new Point(30, 65);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(200, 31);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            lblPassword.Click += lblPassword_Click;
            // 
            // lblKonfirmasi
            // 
            lblKonfirmasi.BackColor = Color.Transparent;
            lblKonfirmasi.Location = new Point(30, 133);
            lblKonfirmasi.Name = "lblKonfirmasi";
            lblKonfirmasi.Size = new Size(200, 34);
            lblKonfirmasi.TabIndex = 4;
            lblKonfirmasi.Text = "Konfirmasi Password";
            lblKonfirmasi.Click += lblKonfirmasi_Click;
            // 
            // FormDaftar
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(471, 317);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblKonfirmasi);
            Controls.Add(txtKonfirmasiPassword);
            Controls.Add(btnDaftar);
            Name = "FormDaftar";
            Text = "Daftar Akun Baru";
            Load += FormDaftar_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
