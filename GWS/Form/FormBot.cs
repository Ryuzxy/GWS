using System;
using System.Windows.Forms;
using GWS.Bot;
using GWS.Models;

namespace BotChat
{
    public partial class FormBotChats : Form
    {
        private BotLogic bot;
        private User currentUser;

        public FormBotChats(User user)
        {
            InitializeComponent();
            bot = new BotLogic();
            currentUser = user;
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            TextBox txtInput = new TextBox();
            txtInput.Location = new Point(10, 10);
            string userInput = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(userInput)) return;

            string botResponse = bot.GetResponse(userInput, currentUser.Role);
            TextBox txtChat = new TextBox();
            txtChat.AppendText($"Anda: {userInput}\n");
            txtChat.AppendText($"Bot: {botResponse}\n\n");
            txtInput.Clear();
        }

        private void txtChat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
