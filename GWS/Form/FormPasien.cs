using System;
using System.Windows.Forms;
using GWS.Repositories;
using System.Collections.Generic;
using GWS.Models;


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
   
            var jadwalRepository = new JadwalReposit();
            List<Jadwal> jadwals = jadwalRepository.GetAll();
            foreach (var jadwal in jadwals)
            {
                dgvJadwal.Rows.Add(jadwal.Hari, jadwal.Jam, jadwal.Dokter);
            }



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
                MessageBox.Show($"Anda telah mendaftar untuk: {listPeriksa.SelectedItem}");
            }
            else
            {
                MessageBox.Show("Silakan pilih layanan untuk daftar.");
            }
        }
    }
}
