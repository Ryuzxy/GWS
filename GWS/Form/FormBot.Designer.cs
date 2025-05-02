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
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnKirim = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtChat
            this.txtChat.Location = new System.Drawing.Point(12, 12);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(360, 200);
            this.txtChat.TabIndex = 0;

            // txtInput
            this.txtInput.Location = new System.Drawing.Point(12, 220);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(280, 23);
            this.txtInput.TabIndex = 1;

            // btnKirim
            this.btnKirim.Location = new System.Drawing.Point(300, 220);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(75, 23);
            this.btnKirim.TabIndex = 2;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);

            // FormBotChats
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtChat);
            this.Name = "FormBotChats";
            this.Text = "Bot Chat";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
