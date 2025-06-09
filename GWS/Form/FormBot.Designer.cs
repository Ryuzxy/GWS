namespace BotChat
{
    partial class FormBotChats
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnKirim;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtChat = new TextBox();
            txtInput = new TextBox();
            btnKirim = new Button();
            SuspendLayout();
            // 
            // txtChat
            // 
            txtChat.Location = new Point(12, 12);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = ScrollBars.Vertical;
            txtChat.Size = new Size(360, 200);
            txtChat.TabIndex = 0;
            txtChat.TextChanged += txtChat_TextChanged;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 220);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(280, 31);
            txtInput.TabIndex = 1;
            // 
            // btnKirim
            // 
            btnKirim.Location = new Point(300, 220);
            btnKirim.Name = "btnKirim";
            btnKirim.Size = new Size(75, 31);
            btnKirim.TabIndex = 2;
            btnKirim.Text = "Kirim";
            btnKirim.UseVisualStyleBackColor = true;
            btnKirim.Click += btnKirim_Click;
            // 
            // FormBotChats
            // 
            ClientSize = new Size(395, 280);
            Controls.Add(btnKirim);
            Controls.Add(txtInput);
            Controls.Add(txtChat);
            Name = "FormBotChats";
            Text = "Bot Chat";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
