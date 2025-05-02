namespace PasienFOrm
{
    partial class FormPasien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabJadwal;
        private System.Windows.Forms.TabPage tabBot;
        private System.Windows.Forms.TabPage tabPeriksa;
        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.ListBox listPeriksa;
        private System.Windows.Forms.Button btnDaftarPeriksa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHari;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDokter;

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabJadwal = new System.Windows.Forms.TabPage();
            this.dgvJadwal = new System.Windows.Forms.DataGridView();
            this.colHari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabBot = new System.Windows.Forms.TabPage();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnKirim = new System.Windows.Forms.Button();
            this.tabPeriksa = new System.Windows.Forms.TabPage();
            this.listPeriksa = new System.Windows.Forms.ListBox();
            this.btnDaftarPeriksa = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabJadwal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).BeginInit();
            this.tabBot.SuspendLayout();
            this.tabPeriksa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabJadwal);
            this.tabControl.Controls.Add(this.tabBot);
            this.tabControl.Controls.Add(this.tabPeriksa);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(600, 400);
            this.tabControl.TabIndex = 0;
            // 
            // tabJadwal
            // 
            this.tabJadwal.Controls.Add(this.dgvJadwal);
            this.tabJadwal.Location = new System.Drawing.Point(4, 24);
            this.tabJadwal.Name = "tabJadwal";
            this.tabJadwal.Padding = new System.Windows.Forms.Padding(3);
            this.tabJadwal.Size = new System.Drawing.Size(592, 372);
            this.tabJadwal.TabIndex = 0;
            this.tabJadwal.Text = "Jadwal";
            this.tabJadwal.UseVisualStyleBackColor = true;
            // 
            // dgvJadwal
            // 
            this.dgvJadwal.AllowUserToAddRows = false;
            this.dgvJadwal.AllowUserToDeleteRows = false;
            this.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHari,
            this.colJam,
            this.colDokter});
            this.dgvJadwal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJadwal.Location = new System.Drawing.Point(3, 3);
            this.dgvJadwal.Name = "dgvJadwal";
            this.dgvJadwal.ReadOnly = true;
            this.dgvJadwal.Size = new System.Drawing.Size(586, 366);
            this.dgvJadwal.TabIndex = 0;
            // 
            // colHari
            // 
            this.colHari.HeaderText = "Hari";
            this.colHari.Name = "colHari";
            this.colHari.ReadOnly = true;
            // 
            // colJam
            // 
            this.colJam.HeaderText = "Jam";
            this.colJam.Name = "colJam";
            this.colJam.ReadOnly = true;
            // 
            // colDokter
            // 
            this.colDokter.HeaderText = "Dokter";
            this.colDokter.Name = "colDokter";
            this.colDokter.ReadOnly = true;
            // 
            // tabBot
            // 
            this.tabBot.Controls.Add(this.txtChat);
            this.tabBot.Controls.Add(this.txtInput);
            this.tabBot.Controls.Add(this.btnKirim);
            this.tabBot.Location = new System.Drawing.Point(4, 24);
            this.tabBot.Name = "tabBot";
            this.tabBot.Padding = new System.Windows.Forms.Padding(3);
            this.tabBot.Size = new System.Drawing.Size(592, 372);
            this.tabBot.TabIndex = 1;
            this.tabBot.Text = "Bot Pembantu";
            this.tabBot.UseVisualStyleBackColor = true;
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(6, 6);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(580, 280);
            this.txtChat.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 292);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(480, 23);
            this.txtInput.TabIndex = 1;
            // 
            // btnKirim
            // 
            this.btnKirim.Location = new System.Drawing.Point(492, 291);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(94, 25);
            this.btnKirim.TabIndex = 2;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // tabPeriksa
            // 
            this.tabPeriksa.Controls.Add(this.listPeriksa);
            this.tabPeriksa.Controls.Add(this.btnDaftarPeriksa);
            this.tabPeriksa.Location = new System.Drawing.Point(4, 24);
            this.tabPeriksa.Name = "tabPeriksa";
            this.tabPeriksa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPeriksa.Size = new System.Drawing.Size(592, 372);
            this.tabPeriksa.TabIndex = 2;
            this.tabPeriksa.Text = "Daftar Periksa";
            this.tabPeriksa.UseVisualStyleBackColor = true;
            // 
            // listPeriksa
            // 
            this.listPeriksa.FormattingEnabled = true;
            this.listPeriksa.ItemHeight = 15;
            this.listPeriksa.Location = new System.Drawing.Point(6, 6);
            this.listPeriksa.Name = "listPeriksa";
            this.listPeriksa.Size = new System.Drawing.Size(580, 319);
            this.listPeriksa.TabIndex = 0;
            // 
            // btnDaftarPeriksa
            // 
            this.btnDaftarPeriksa.Location = new System.Drawing.Point(6, 331);
            this.btnDaftarPeriksa.Name = "btnDaftarPeriksa";
            this.btnDaftarPeriksa.Size = new System.Drawing.Size(580, 30);
            this.btnDaftarPeriksa.TabIndex = 1;
            this.btnDaftarPeriksa.Text = "Daftar Periksa";
            this.btnDaftarPeriksa.UseVisualStyleBackColor = true;
            this.btnDaftarPeriksa.Click += new System.EventHandler(this.btnDaftarPeriksa_Click);
            // 
            // FormPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.tabControl);
            this.Name = "FormPasien";
            this.Text = "Form Pasien";
            this.Load += new System.EventHandler(this.FormPasien_Load);
            this.tabControl.ResumeLayout(false);
            this.tabJadwal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).EndInit();
            this.tabBot.ResumeLayout(false);
            this.tabBot.PerformLayout();
            this.tabPeriksa.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
