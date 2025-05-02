using System;
using System.Windows.Forms;
using Npgsql;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;

namespace Register
{
    public partial class FormDaftar : Form
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public FormDaftar()
        {
            InitializeComponent();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string konfirmasi = txtKonfirmasiPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password harus diisi!");
                return;
            }

            if (password != konfirmasi)
            {
                MessageBox.Show("Konfirmasi password tidak cocok!");
                return;
            }

            string hashedPassword = HashPassword(password);
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    // Cek apakah username sudah ada
                    using (var checkCmd = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE username = @username", conn))
                    {
                        checkCmd.Parameters.AddWithValue("username", username);
                        var count = (long)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Username sudah terdaftar. Pilih username lain.");
                            return;
                        }
                    }

                    // Insert user baru
                    using (var cmd = new NpgsqlCommand("INSERT INTO users (username, password) VALUES (@username, @password)", conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", hashedPassword);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Akun untuk '{username}' berhasil didaftarkan!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
