namespace PasienFOrm
{
    partial class FormPasien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabJadwal;
        private System.Windows.Forms.TabPage tabDokter;
        private System.Windows.Forms.TabPage tabBot;
        private System.Windows.Forms.TabPage tabPeriksa;
        private System.Windows.Forms.DataGridView dgvDokter;
        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.ListBox listPeriksa;
        private System.Windows.Forms.Button btnDaftarPeriksa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHari;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpesialis;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPasien));
            tabControl = new TabControl();
            tabJadwal = new TabPage();
            dgvJadwal = new DataGridView();
            colHari = new DataGridViewTextBoxColumn();
            colJam = new DataGridViewTextBoxColumn();
            colDokter = new DataGridViewTextBoxColumn();
            tabDokter = new TabPage();
            dgvDokter = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colSpesialis = new DataGridViewTextBoxColumn();
            tabBot = new TabPage();
            txtChat = new TextBox();
            txtInput = new TextBox();
            btnKirim = new Button();
            tabPeriksa = new TabPage();
            listPeriksa = new ListBox();
            btnDaftarPeriksa = new Button();
            tabControl.SuspendLayout();
            tabJadwal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
            tabDokter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDokter).BeginInit();
            tabBot.SuspendLayout();
            tabPeriksa.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabJadwal);
            tabControl.Controls.Add(tabDokter);
            tabControl.Controls.Add(tabBot);
            tabControl.Controls.Add(tabPeriksa);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(4, 5, 4, 5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(762, 667);
            tabControl.TabIndex = 0;
            // 
            // tabJadwal
            // 
            // tabJadwal
            tabJadwal.BackgroundImage = null; // Hapus jika background image tidak diperlukan atau hilangkan jika ingin pakai background image
            tabJadwal.BackgroundImageLayout = ImageLayout.None; // atau sesuai kebutuhan
                                                                // tabJadwal.ForeColor = Color.Transparent; // Hapus baris ini supaya teks tab terlihat
            tabJadwal.Controls.Add(dgvJadwal);
            tabJadwal.Location = new Point(4, 34);
            tabJadwal.Margin = new Padding(4, 5, 4, 5);
            tabJadwal.Name = "tabJadwal";
            tabJadwal.Padding = new Padding(4, 5, 4, 5);
            tabJadwal.Size = new Size(754, 629);
            tabJadwal.TabIndex = 0;
            tabJadwal.Text = "Jadwal";
            tabJadwal.UseVisualStyleBackColor = true;

            // dgvJadwal
            dgvJadwal.AllowUserToAddRows = false;
            dgvJadwal.AllowUserToDeleteRows = false;
            dgvJadwal.BackgroundColor = SystemColors.ScrollBar;
            dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwal.Columns.AddRange(new DataGridViewColumn[] { colHari, colJam, colDokter });
            dgvJadwal.Dock = DockStyle.Fill; // Ini sudah benar agar dgv mengisi tab
            dgvJadwal.GridColor = Color.Black;
            // Tidak perlu set Location dan Size manual karena Dock=Fill sudah mengatur
            dgvJadwal.ReadOnly = true;
            dgvJadwal.RowHeadersWidth = 62;
            dgvJadwal.CellContentClick += dgvJadwal_CellContentClick;

            // colHari
            // 
            colHari.HeaderText = "Hari";
            colHari.MinimumWidth = 8;
            colHari.Name = "colHari";
            colHari.ReadOnly = true;
            colHari.Width = 150;
            // 
            // colJam
            // 
            colJam.HeaderText = "Jam";
            colJam.MinimumWidth = 8;
            colJam.Name = "colJam";
            colJam.ReadOnly = true;
            colJam.Width = 150;
            // 
            // colDokter
            // 
            colDokter.HeaderText = "Dokter";
            colDokter.MinimumWidth = 8;
            colDokter.Name = "colDokter";
            colDokter.ReadOnly = true;
            colDokter.Width = 150;
            // 
            // tabDokter
            // 
            tabDokter.Controls.Add(dgvDokter);
            tabDokter.Location = new Point(4, 34);
            tabDokter.Margin = new Padding(4, 5, 4, 5);
            tabDokter.Name = "tabDokter";
            tabDokter.Padding = new Padding(4, 5, 4, 5);
            tabDokter.Size = new Size(754, 629);
            tabDokter.TabIndex = 0;
            tabDokter.Text = "Dokter";
            tabDokter.UseVisualStyleBackColor = true;
            // 
            // dgvDokter
            // 
            dgvDokter.AllowUserToAddRows = false;
            dgvDokter.AllowUserToDeleteRows = false;
            dgvDokter.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDokter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDokter.Columns.AddRange(new DataGridViewColumn[] { colId, colNama, colSpesialis });
            dgvDokter.Dock = DockStyle.Fill;
            dgvDokter.Location = new Point(4, 5);
            dgvDokter.Margin = new Padding(4, 5, 4, 5);
            dgvDokter.Name = "dgvDokter";
            dgvDokter.ReadOnly = true;
            dgvDokter.RowHeadersWidth = 62;
            dgvDokter.Size = new Size(746, 619);
            dgvDokter.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "Id Dokter";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 150;
            // 
            // colNama
            // 
            colNama.HeaderText = "Nama Dokter";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            colNama.Width = 150;
            // 
            // colSpesialis
            // 
            colSpesialis.HeaderText = "Spesialis Penyakit";
            colSpesialis.MinimumWidth = 8;
            colSpesialis.Name = "colSpesialis";
            colSpesialis.ReadOnly = true;
            colSpesialis.Width = 150;
            // 
            // tabBot
            // 
            tabBot.Controls.Add(txtChat);
            tabBot.Controls.Add(txtInput);
            tabBot.Controls.Add(btnKirim);
            tabBot.Location = new Point(4, 34);
            tabBot.Margin = new Padding(4, 5, 4, 5);
            tabBot.Name = "tabBot";
            tabBot.Padding = new Padding(4, 5, 4, 5);
            tabBot.Size = new Size(754, 629);
            tabBot.TabIndex = 1;
            tabBot.Text = "Bot Pembantu";
            tabBot.UseVisualStyleBackColor = true;
            // 
            // txtChat
            // 
            txtChat.Location = new Point(9, 10);
            txtChat.Margin = new Padding(4, 5, 4, 5);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = ScrollBars.Vertical;
            txtChat.Size = new Size(827, 464);
            txtChat.TabIndex = 0;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(9, 487);
            txtInput.Margin = new Padding(4, 5, 4, 5);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(684, 31);
            txtInput.TabIndex = 1;
            // 
            // btnKirim
            // 
            btnKirim.Location = new Point(703, 485);
            btnKirim.Margin = new Padding(4, 5, 4, 5);
            btnKirim.Name = "btnKirim";
            btnKirim.Size = new Size(134, 42);
            btnKirim.TabIndex = 2;
            btnKirim.Text = "Kirim";
            btnKirim.UseVisualStyleBackColor = true;
            btnKirim.Click += btnKirim_Click;
            // 
            // tabPeriksa
            // 
            tabPeriksa.Controls.Add(listPeriksa);
            tabPeriksa.Controls.Add(btnDaftarPeriksa);
            tabPeriksa.Location = new Point(4, 34);
            tabPeriksa.Margin = new Padding(4, 5, 4, 5);
            tabPeriksa.Name = "tabPeriksa";
            tabPeriksa.Padding = new Padding(4, 5, 4, 5);
            tabPeriksa.Size = new Size(754, 629);
            tabPeriksa.TabIndex = 2;
            tabPeriksa.Text = "Daftar Periksa";
            tabPeriksa.UseVisualStyleBackColor = true;
            // 
            // listPeriksa
            // 
            listPeriksa.FormattingEnabled = true;
            listPeriksa.Location = new Point(4, 5);
            listPeriksa.Margin = new Padding(4, 5, 4, 5);
            listPeriksa.Name = "listPeriksa";
            listPeriksa.Size = new Size(827, 529);
            listPeriksa.TabIndex = 0;
            // 
            // btnDaftarPeriksa
            // 
            btnDaftarPeriksa.Location = new Point(9, 552);
            btnDaftarPeriksa.Margin = new Padding(4, 5, 4, 5);
            btnDaftarPeriksa.Name = "btnDaftarPeriksa";
            btnDaftarPeriksa.Size = new Size(829, 50);
            btnDaftarPeriksa.TabIndex = 1;
            btnDaftarPeriksa.Text = "Daftar Periksa";
            btnDaftarPeriksa.UseVisualStyleBackColor = true;
            btnDaftarPeriksa.Click += btnDaftarPeriksa_Click;
            // 
            // FormPasien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 667);
            Controls.Add(tabControl);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPasien";
            Text = "Form Pasien";
            Load += FormPasien_Load;
            tabControl.ResumeLayout(false);
            tabJadwal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
            tabDokter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDokter).EndInit();
            tabBot.ResumeLayout(false);
            tabBot.PerformLayout();
            tabPeriksa.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
