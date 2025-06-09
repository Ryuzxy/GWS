using LoginForm;
using PasienFOrm;
using PasienS.Forms;
using System;
using System.Windows.Forms;

namespace RolePilih
{
    public partial class FormRoleSelector : Form
    {
        public FormRoleSelector()
        {
            InitializeComponent();
        }

        private void btnPasien_Click(object sender, EventArgs e)
        {
            var formPasien = new FormPasien();
            formPasien.Show();
            this.Hide(); // opsional
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.Show();
            this.Hide(); // opsional
        }

        private void FormRoleSelector_Load(object sender, EventArgs e)
        {

        }
    }
}
