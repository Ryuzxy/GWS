using DokterForm.Forms;
using GWS.Forms;
using PasienS.Forms;
using System;
using System.Windows.Forms;

namespace GWS.Form
{
    public partial class FormAdmin : System.Windows.Forms.Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnPasien_Click(object sender, EventArgs e)
        {
            var form = new FormPasiens(); // Pastikan ini sudah dibuat
            form.ShowDialog();
        }

        private void btnDokter_Click(object sender, EventArgs e)
        {
            var form = new FormCRUDDokter(); // Tambahkan FormDokter jika belum ada
            form.ShowDialog();
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            var form = new JadwalForm.Forms.FormJadwal(); // Sesuaikan namespace
            form.ShowDialog();
        }

        private void btnPeriksa_Click(object sender, EventArgs e)
        {
            var form = new FormPeriksa(); // Tambahkan FormPeriksa jika belum ada
            form.ShowDialog();
        }
        private void btnObat_Click(object sender, EventArgs e)
        {
            var form = new FormObat(); // Tambahkan FormPeriksa jika belum ada
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); // Tutup form admin, kembali ke login
        }
    }
}
