using System;
using System.Windows.Forms;
using GWS;
using GWS.Models;
using Register;

namespace LoginForm
{
    public partial class FormLogin : Form
    {
        private DatabaseHelper _dbHelper;

        public FormLogin()
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Cek login dengan database dan dapatkan objek user (termasuk role dan id)
            User user = _dbHelper.CheckLogin(username, password);  // Mendapatkan objek User yang lengkap

            if (user != null)
            {
                // Jika login berhasil, arahkan ke form utama dengan objek user yang sudah lengkap
                MainForms.FormUtama formUtama = new MainForms.FormUtama(user);
                this.Hide();
                formUtama.Show();
            }
            else
            {
                // Jika login gagal
                MessageBox.Show("Login gagal, username atau password salah.");
            }
        }
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            // Menampilkan FormDaftar untuk registrasi akun baru
            FormDaftar formDaftar = new FormDaftar();
            formDaftar.ShowDialog();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
