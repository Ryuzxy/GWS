using System;
using System.Windows.Forms;
using GWS.Repositories;
using GWS.Models;

namespace DokterForm.Forms
{
    public partial class FormCRUDDokter : Form
    {
        private DokterRepository _repo = new DokterRepository();

        public FormCRUDDokter()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = _repo.GetAll();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            var dokter = new Dokter
            {
                Nama = txtNama.Text,
                Spesialis = txtSpesialis.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = "dokter"
            };
            _repo.Insert(dokter);
            LoadData();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var dokter = (Dokter)dataGridView1.CurrentRow.DataBoundItem;
            dokter.Nama = txtNama.Text;
            dokter.Spesialis = txtSpesialis.Text;
            dokter.Username = txtUsername.Text;
            dokter.Password = txtPassword.Text;
            _repo.Update(dokter);
            LoadData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var dokter = (Dokter)dataGridView1.CurrentRow.DataBoundItem;
            _repo.Delete(dokter.Id);
            LoadData();
        }
    }
}