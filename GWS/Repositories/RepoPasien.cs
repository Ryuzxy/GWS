using System;
using System.Collections.Generic;
using System.Data;
using GWS.Models;
using Npgsql;

namespace GWS.Repositories
{
    public class PasienRepository
    {
        public List<Pasien> GetAll()
        {
            var list = new List<Pasien>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM pasien", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Pasien
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Nama = reader["nama"].ToString(),
                    TanggalLahir = Convert.ToDateTime(reader["tanggal_lahir"]),
                    Alamat = reader["alamat"].ToString(),
                    JenisKelamin = reader["jenis_kelamin"].ToString(),
                    NoTelepon = reader["no_telepon"].ToString()
                });
            }
            return list;
        }

        public void Insert(Pasien pasien)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("INSERT INTO pasien (nama, tanggal_lahir, alamat, jenis_kelamin, no_telepon) VALUES (@nama, @tgl, @alamat, @jk, @no)", conn);
            cmd.Parameters.AddWithValue("@nama", pasien.Nama);
            cmd.Parameters.AddWithValue("@tgl", pasien.TanggalLahir);
            cmd.Parameters.AddWithValue("@alamat", pasien.Alamat);
            cmd.Parameters.AddWithValue("@jk", pasien.JenisKelamin);
            cmd.Parameters.AddWithValue("@no", pasien.NoTelepon);
            cmd.ExecuteNonQuery();
        }

        public void Update(Pasien pasien)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("UPDATE pasien SET nama = @nama, tanggal_lahir = @tgl, alamat = @alamat, jenis_kelamin = @jk, no_telepon = @no WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", pasien.Id);
            cmd.Parameters.AddWithValue("@nama", pasien.Nama);
            cmd.Parameters.AddWithValue("@tgl", pasien.TanggalLahir);
            cmd.Parameters.AddWithValue("@alamat", pasien.Alamat);
            cmd.Parameters.AddWithValue("@jk", pasien.JenisKelamin);
            cmd.Parameters.AddWithValue("@no", pasien.NoTelepon);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("DELETE FROM pasien WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
