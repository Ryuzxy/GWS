using GWS.Repositories;
using System;
using System.Windows.Forms;
namespace GWS.Forms
{
    public partial class FormPendaftaran : System.Windows.Forms.Form  // <- PASTIKAN MEWARISI 'Form'
    {
        private string _layananDipilih;
        private readonly PendaftaranRepository _repo;


        public FormPendaftaran(string layananDipilih)
        {
            InitializeComponent();
            _layananDipilih = layananDipilih;
            lblLayanan.Text = $"Anda mendaftar untuk: {_layananDipilih}";
            _repo = new PendaftaranRepository();

            // Isi combobox jenis kelamin
            cmbJenisKelamin.Items.Add("Laki-laki");
            cmbJenisKelamin.Items.Add("Perempuan");
            cmbJenisKelamin.SelectedIndex = 0; // default
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = txtNama.Text.Trim();
                DateTime tgl = dtpTanggalLahir.Value;
                string jk = cmbJenisKelamin.SelectedItem.ToString();
                string alamat = txtAlamat.Text.Trim();
                string telp = txtTelp.Text.Trim();

                if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(alamat) || string.IsNullOrWhiteSpace(telp))
                {
                    MessageBox.Show("Semua data harus diisi.");
                    return;
                }

                _repo.Insert(nama, tgl, jk, alamat, telp, _layananDipilih);
                MessageBox.Show("Pendaftaran berhasil!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}