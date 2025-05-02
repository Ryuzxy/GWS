using System;
using System.Windows.Forms;
using GWS.Repositories;
using GWS.Models;

namespace PasienS.Forms
{
    public partial class FormPasiens : Form
    {
        private PasienRepository _repo = new PasienRepository();

        public FormPasiens()
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
            var pasien = new Pasien
            {
                Nama = txtNama.Text,
                TanggalLahir = dtpTanggalLahir.Value,
                Alamat = txtAlamat.Text,
                JenisKelamin = cmbJenisKelamin.Text,
                NoTelepon = txtTelepon.Text
            };
            _repo.Insert(pasien);
            LoadData();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var pasien = (Pasien)dataGridView1.CurrentRow.DataBoundItem;
            pasien.Nama = txtNama.Text;
            pasien.TanggalLahir = dtpTanggalLahir.Value;
            pasien.Alamat = txtAlamat.Text;
            pasien.JenisKelamin = cmbJenisKelamin.Text;
            pasien.NoTelepon = txtTelepon.Text;
            _repo.Update(pasien);
            LoadData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var pasien = (Pasien)dataGridView1.CurrentRow.DataBoundItem;
            _repo.Delete(pasien.Id);
            LoadData();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var pasien = (GWS.Models.Pasien)dataGridView1.CurrentRow.DataBoundItem;
            txtNama.Text = pasien.Nama;
            dtpTanggalLahir.Value = pasien.TanggalLahir;
            txtAlamat.Text = pasien.Alamat;
            cmbJenisKelamin.Text = pasien.JenisKelamin;
            txtTelepon.Text = pasien.NoTelepon;
        }

        private void FormPasiens_Load(object sender, EventArgs e)
        {

        }
    }
}
