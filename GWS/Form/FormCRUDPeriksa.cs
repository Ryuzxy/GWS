using System;
using System.Windows.Forms;
using GWS.Models;
using GWS.Repositories;

namespace GWS.Forms
{
    public partial class FormPeriksa : System.Windows.Forms.Form
    {
        private PeriksaRepository _repo = new PeriksaRepository();

        public FormPeriksa()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvPeriksa.DataSource = _repo.GetAll();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            var periksa = new Periksa
            {
                NamaPemeriksaan = txtNama.Text,
                Deskripsi = txtDeskripsi.Text
            };
            _repo.Insert(periksa);
            LoadData();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvPeriksa.CurrentRow == null) return;
            var periksa = (Periksa)dgvPeriksa.CurrentRow.DataBoundItem;
            periksa.NamaPemeriksaan = txtNama.Text;
            periksa.Deskripsi = txtDeskripsi.Text;
            _repo.Update(periksa);
            LoadData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPeriksa.CurrentRow == null) return;
            var periksa = (Periksa)dgvPeriksa.CurrentRow.DataBoundItem;
            _repo.Delete(periksa.Id);
            LoadData();
        }

    }
}
