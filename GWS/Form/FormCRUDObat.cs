using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GWS.Models;
using GWS.Repositories;

namespace GWS.Forms
{
    public partial class FormObat : System.Windows.Forms.Form
    {
        private readonly ObatRepository _repo = new ObatRepository();

        public FormObat()
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
            var obat = new Obat
            {
                Nama = txtNama.Text,
                Stok = int.Parse(txtStok.Text),
                Keterangan = txtKeterangan.Text
            };
            _repo.Insert(obat);
            LoadData();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Obat obat)
            {
                obat.Nama = txtNama.Text;
                obat.Stok = int.Parse(txtStok.Text);
                obat.Keterangan = txtKeterangan.Text;
                _repo.Update(obat);
                LoadData();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Obat obat)
            {
                _repo.Delete(obat.Id);
                LoadData();
            }
        }
    }
}
