namespace RolePilih
{
    partial class FormRoleSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoleSelector));
            labelTitle = new Label();
            btnPasien = new Button();
            btnDokter = new Button();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.Location = new Point(133, 151);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(188, 48);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Pilih Role:";
            // 
            // btnPasien
            // 
            btnPasien.BackColor = Color.Transparent;
            btnPasien.Font = new Font("Segoe UI", 12F);
            btnPasien.ForeColor = SystemColors.Desktop;
            btnPasien.Location = new Point(150, 220);
            btnPasien.Margin = new Padding(4, 5, 4, 5);
            btnPasien.Name = "btnPasien";
            btnPasien.Size = new Size(143, 67);
            btnPasien.TabIndex = 1;
            btnPasien.Text = "Pasien";
            btnPasien.UseVisualStyleBackColor = false;
            btnPasien.Click += btnPasien_Click;
            // 
            // btnAdmin
            // 
            btnDokter.BackColor = Color.Transparent;
            btnDokter.Font = new Font("Segoe UI", 12F);
            btnDokter.ForeColor = SystemColors.Desktop;
            btnDokter.Location = new Point(150, 320);
            btnDokter.Margin = new Padding(4, 5, 4, 5);
            btnDokter.Name = "btnDokter";
            btnDokter.Size = new Size(143, 67);
            btnDokter.TabIndex = 2;
            btnDokter.Text = "Dokter";
            btnDokter.UseVisualStyleBackColor = false;
            btnDokter.Click += btnDokter_Click;
            // 
            // button1
            // 
            btnAdmin.BackColor = Color.Transparent;
            btnAdmin.Font = new Font("Segoe UI", 12F);
            btnAdmin.ForeColor = SystemColors.Desktop;
            btnAdmin.Location = new Point(150, 418);
            btnAdmin.Margin = new Padding(4, 5, 4, 5);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(143, 67);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // FormRoleSelector
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(447, 673);
            Controls.Add(btnAdmin);
            Controls.Add(btnDokter);
            Controls.Add(btnPasien);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormRoleSelector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Role Selector";
            Load += FormRoleSelector_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnPasien;
        private System.Windows.Forms.Button btnDokter;
        private System.Windows.Forms.Button btnAdmin;
    }
}
