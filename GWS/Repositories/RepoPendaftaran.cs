using System;
using System.Collections.Generic;
using Npgsql;
using GWS.Models; // Asumsikan Anda punya model `Pendaftaran`


namespace GWS.Repositories
{
    public class PendaftaranRepository
    {
        public void Insert(string nama, DateTime tanggalLahir, string jenisKelamin, string alamat, string noTelp, string layanan)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            int pasienId;

            // Cek apakah pasien sudah ada
            string cekQuery = "SELECT id FROM pasien WHERE nama = @nama AND tanggal_lahir = @tgl";
            using (var cekCmd = new NpgsqlCommand(cekQuery, conn))
            {
                cekCmd.Parameters.AddWithValue("@nama", nama);
                cekCmd.Parameters.AddWithValue("@tgl", tanggalLahir);
                var result = cekCmd.ExecuteScalar();

                if (result != null)
                {
                    pasienId = Convert.ToInt32(result);
                }
                else
                {
                    // Insert pasien baru
                    string insertPasien = @"
                INSERT INTO pasien (nama, tanggal_lahir, jenis_kelamin, alamat, no_telepon)
                VALUES (@nama, @tgl, @jk, @alamat, @telp)
                RETURNING id";
                    using var insertCmd = new NpgsqlCommand(insertPasien, conn);
                    insertCmd.Parameters.AddWithValue("@nama", nama);
                    insertCmd.Parameters.AddWithValue("@tgl", tanggalLahir);
                    insertCmd.Parameters.AddWithValue("@jk", jenisKelamin);
                    insertCmd.Parameters.AddWithValue("@alamat", alamat);
                    insertCmd.Parameters.AddWithValue("@telp", noTelp);
                    pasienId = Convert.ToInt32(insertCmd.ExecuteScalar());
                }
            }

            // Insert ke pendaftaran
            string insertPendaftaran = "INSERT INTO pendaftaran (pasien_id, layanan, tanggal) VALUES (@id, @layanan, @tanggal)";
            using var cmd = new NpgsqlCommand(insertPendaftaran, conn);
            cmd.Parameters.AddWithValue("@id", pasienId);
            cmd.Parameters.AddWithValue("@layanan", layanan);
            cmd.Parameters.AddWithValue("@tanggal", DateTime.Now);
            cmd.ExecuteNonQuery();
        }
    }
}