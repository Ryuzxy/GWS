using System;
using System.Windows.Forms;
using GWS.Repositories;
using System.Collections.Generic;
using GWS.Models;
using GWS.Forms;



namespace PasienFOrm
{
    public partial class FormPasien : Form
    {
        public FormPasien()
        {
            InitializeComponent();
        }

        private void FormPasien_Load(object sender, EventArgs e)
        {

            dgvJadwal.Rows.Clear();

            var jadwalRepository = new JadwalReposit();
            List<Jadwal> jadwals = jadwalRepository.GetAll();

            foreach (var jadwal in jadwals)
            {
                dgvJadwal.Rows.Add(jadwal.Hari, jadwal.Jam, jadwal.Dokter);
            }

      
            var dokterRepo = new DokterRepository();
            List<Dokter> dokters = dokterRepo.GetAll();
            foreach (var dokter in dokters)
                dgvDokter.Rows.Add(dokter.Id, dokter.Nama, dokter.Spesialis);



            // Daftar Periksa
            var periksaRepo = new PeriksaRepository();
            List<Periksa> periksas = periksaRepo.GetAll();
            foreach (var periksa in periksas)
            {
                listPeriksa.Items.Add(periksa.NamaPemeriksaan);
            }
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                txtChat.AppendText("Anda: " + input + Environment.NewLine);
                // Dummy response dari bot
                txtChat.AppendText("Bot: Terima kasih atas pertanyaannya 😊" + Environment.NewLine);
                txtInput.Clear();
            }
        }

        private void btnDaftarPeriksa_Click(object sender, EventArgs e)
        {
            if (listPeriksa.SelectedItem != null)
            {
                string layanan = listPeriksa.SelectedItem.ToString(); // ambil string layanan dari listPeriksa
                var form = new FormPendaftaran(layanan);  // kirim layanan ke constructor
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Silakan pilih layanan untuk melihat deskripsi.");
            }
        }

        private void dgvJadwal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
