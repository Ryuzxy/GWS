using System.Windows.Forms;

namespace GWS.Forms
{
    partial class FormPendaftaran
    {
        private System.Windows.Forms.Label lblLayanan;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblTanggalLahir;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.Label lblJenisKelamin;
        private System.Windows.Forms.ComboBox cmbJenisKelamin;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label lblTelp;
        private System.Windows.Forms.TextBox txtTelp;
        private System.Windows.Forms.Button btnKirim;

        private void InitializeComponent()
        {
            this.lblLayanan = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblTanggalLahir = new System.Windows.Forms.Label();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.lblJenisKelamin = new System.Windows.Forms.Label();
            this.cmbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblTelp = new System.Windows.Forms.Label();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.btnKirim = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblLayanan
            this.lblLayanan.AutoSize = true;
            this.lblLayanan.Location = new System.Drawing.Point(20, 20);
            this.lblLayanan.Size = new System.Drawing.Size(200, 20);
            this.lblLayanan.Text = "Anda mendaftar untuk: [layanan]";

            // lblNama
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(20, 60);
            this.lblNama.Text = "Nama:";

            // txtNama
            this.txtNama.Location = new System.Drawing.Point(150, 60);
            this.txtNama.Size = new System.Drawing.Size(200, 23);

            // lblTanggalLahir
            this.lblTanggalLahir.AutoSize = true;
            this.lblTanggalLahir.Location = new System.Drawing.Point(20, 100);
            this.lblTanggalLahir.Text = "Tanggal Lahir:";

            // dtpTanggalLahir
            this.dtpTanggalLahir.Location = new System.Drawing.Point(150, 100);
            this.dtpTanggalLahir.Size = new System.Drawing.Size(200, 23);

            // lblJenisKelamin
            this.lblJenisKelamin.AutoSize = true;
            this.lblJenisKelamin.Location = new System.Drawing.Point(20, 140);
            this.lblJenisKelamin.Text = "Jenis Kelamin:";

            // cmbJenisKelamin
            this.cmbJenisKelamin.Location = new System.Drawing.Point(150, 140);
            this.cmbJenisKelamin.Size = new System.Drawing.Size(200, 23);

            // lblAlamat
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(20, 180);
            this.lblAlamat.Text = "Alamat:";

            // txtAlamat
            this.txtAlamat.Location = new System.Drawing.Point(150, 180);
            this.txtAlamat.Size = new System.Drawing.Size(200, 23);

            // lblTelp
            this.lblTelp.AutoSize = true;
            this.lblTelp.Location = new System.Drawing.Point(20, 220);
            this.lblTelp.Text = "No. Telepon:";

            // txtTelp
            this.txtTelp.Location = new System.Drawing.Point(150, 220);
            this.txtTelp.Size = new System.Drawing.Size(200, 23);

            // btnKirim
            this.btnKirim.Location = new System.Drawing.Point(150, 270);
            this.btnKirim.Size = new System.Drawing.Size(100, 30);
            this.btnKirim.Text = "Kirim";
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);

            // FormPendaftaran
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 330);
            this.Controls.Add(this.lblLayanan);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblTanggalLahir);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.lblJenisKelamin);
            this.Controls.Add(this.cmbJenisKelamin);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.lblTelp);
            this.Controls.Add(this.txtTelp);
            this.Controls.Add(this.btnKirim);
            this.Name = "FormPendaftaran";
            this.Text = "Form Pendaftaran";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}