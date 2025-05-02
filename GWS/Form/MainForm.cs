using System;
using System.Windows.Forms;
using BotChat;
using GWS.Models;
using PasienS.Forms;

namespace MainForms
{
    public partial class FormUtama : Form
    {
        private User currentUser;

        public FormUtama(User user)
        {
            InitializeComponent();
            currentUser = user;
            labelWelcome.Text = $"Selamat datang, {currentUser.Username} ({currentUser.Role})";
        }
        private void btnPasien_Click(object sender, EventArgs e)
        {
            FormPasiens form = new FormPasiens();
            form.ShowDialog();
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            FormBotChats form = new FormBotChats(currentUser);
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
