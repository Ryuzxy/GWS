using System;
using System.Windows.Forms;
using GWS.Models;
using GWS.Repositories;

namespace JadwalForm.Forms
{
    public partial class FormJadwal : Form
    {
        private readonly JadwalReposit _repo = new JadwalReposit();

        public FormJadwal()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null; // Clear dulu
            dataGridView1.DataSource = _repo.GetAll();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDokterId.Text) ||
                string.IsNullOrWhiteSpace(txtHari.Text) ||
                string.IsNullOrWhiteSpace(txtJamMulai.Text) ||
                string.IsNullOrWhiteSpace(txtJamSelesai.Text))
            {
                MessageBox.Show("Semua field harus diisi!");
                return;
            }

            var jadwal = new Jadwal
            {
                Dokter = txtDokterId.Text,
                Hari = txtHari.Text,
                Jam = $"{txtJamMulai.Text} - {txtJamSelesai.Text}"
            };

            _repo.Insert(jadwal);
            LoadData();
            ClearForm();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang mau diubah.");
                return;
            }

            var jadwal = (Jadwal)dataGridView1.CurrentRow.DataBoundItem;

            jadwal.Dokter = txtDokterId.Text;
            jadwal.Hari = txtHari.Text;
            jadwal.Jam = $"{txtJamMulai.Text} - {txtJamSelesai.Text}";

            _repo.Update(jadwal);
            LoadData();
            ClearForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang mau dihapus.");
                return;
            }

            var jadwal = (Jadwal)dataGridView1.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show($"Yakin mau hapus jadwal {jadwal.Dokter} - {jadwal.Hari}?", 
                "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _repo.Delete(jadwal.Id);
                LoadData();
                ClearForm();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var jadwal = (Jadwal)dataGridView1.CurrentRow.DataBoundItem;
                txtDokterId.Text = jadwal.Dokter;
                txtHari.Text = jadwal.Hari;

                // Pecah Jam jika ada separator " - "
                if (jadwal.Jam != null && jadwal.Jam.Contains(" - "))
                {
                    var parts = jadwal.Jam.Split(" - ");
                    txtJamMulai.Text = parts[0];
                    txtJamSelesai.Text = parts.Length > 1 ? parts[1] : "";
                }
                else
                {
                    txtJamMulai.Text = "";
                    txtJamSelesai.Text = "";
                }
            }
        }

        private void ClearForm()
        {
            txtDokterId.Clear();
            txtHari.Clear();
            txtJamMulai.Clear();
            txtJamSelesai.Clear();
        }
    }
}
