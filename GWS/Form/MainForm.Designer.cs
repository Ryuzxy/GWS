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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtama));
            labelWelcome = new Label();
            btnPasien = new Button();
            btnBot = new Button();
            btnLogout = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.BackColor = Color.Transparent;
            labelWelcome.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelWelcome.ForeColor = Color.MidnightBlue;
            labelWelcome.Location = new Point(245, 93);
            labelWelcome.Margin = new Padding(4, 0, 4, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(320, 38);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Selamat datang, User";
            labelWelcome.Click += labelWelcome_Click;
            // 
            // btnPasien
            // 
            btnPasien.BackColor = Color.Transparent;
            btnPasien.BackgroundImage = (Image)resources.GetObject("btnPasien.BackgroundImage");
            btnPasien.ForeColor = SystemColors.ActiveCaptionText;
            btnPasien.Location = new Point(13, 52);
            btnPasien.Margin = new Padding(4, 5, 4, 5);
            btnPasien.Name = "btnPasien";
            btnPasien.Size = new Size(214, 50);
            btnPasien.TabIndex = 1;
            btnPasien.Text = "Manajemen Pasien";
            btnPasien.UseVisualStyleBackColor = false;
            btnPasien.Click += btnPasien_Click;
            // 
            // btnBot
            // 
            btnBot.BackgroundImage = (Image)resources.GetObject("btnBot.BackgroundImage");
            btnBot.ForeColor = Color.DarkBlue;
            btnBot.Location = new Point(12, 147);
            btnBot.Margin = new Padding(4, 5, 4, 5);
            btnBot.Name = "btnBot";
            btnBot.Size = new Size(214, 50);
            btnBot.TabIndex = 2;
            btnBot.Text = "Chat Bot";
            btnBot.UseVisualStyleBackColor = true;
            btnBot.Click += btnBot_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.ForeColor = SystemColors.MenuText;
            btnLogout.Location = new Point(13, 234);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(214, 50);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(407, 149);
            label1.Name = "label1";
            label1.Size = new Size(48, 38);
            label1.TabIndex = 4;
            label1.Text = "Di";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(305, 214);
            label2.Name = "label2";
            label2.Size = new Size(260, 38);
            label2.TabIndex = 5;
            label2.Text = "Dashboard Klinik";
            // 
            // FormUtama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(580, 366);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelWelcome);
            Controls.Add(btnPasien);
            Controls.Add(btnBot);
            Controls.Add(btnLogout);
            ForeColor = SystemColors.ControlDarkDark;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormUtama";
            Text = "Dashboard Klinik";
            Load += FormUtama_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
    }
}
