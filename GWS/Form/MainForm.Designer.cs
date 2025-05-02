// FormUtama.Designer.cs
namespace MainForms
{
    partial class FormUtama
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btnPasien;
        private System.Windows.Forms.Button btnBot;
        private System.Windows.Forms.Button btnLogout;

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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btnPasien = new System.Windows.Forms.Button();
            this.btnBot = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelWelcome
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Location = new System.Drawing.Point(30, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(160, 21);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Selamat datang, User";

            // btnPasien
            this.btnPasien.Location = new System.Drawing.Point(30, 70);
            this.btnPasien.Name = "btnPasien";
            this.btnPasien.Size = new System.Drawing.Size(150, 30);
            this.btnPasien.TabIndex = 1;
            this.btnPasien.Text = "Manajemen Pasien";
            this.btnPasien.UseVisualStyleBackColor = true;
            this.btnPasien.Click += new System.EventHandler(this.btnPasien_Click);

            // btnBot
            this.btnBot.Location = new System.Drawing.Point(30, 110);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(150, 30);
            this.btnBot.TabIndex = 2;
            this.btnBot.Text = "Chat Bot";
            this.btnBot.UseVisualStyleBackColor = true;
            this.btnBot.Click += new System.EventHandler(this.btnBot_Click);

            // btnLogout
            this.btnLogout.Location = new System.Drawing.Point(30, 150);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 30);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // FormUtama
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.btnPasien);
            this.Controls.Add(this.btnBot);
            this.Controls.Add(this.btnLogout);
            this.Name = "FormUtama";
            this.Text = "Dashboard Klinik";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
