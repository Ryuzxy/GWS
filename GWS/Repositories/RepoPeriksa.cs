using System.Collections.Generic;
using Npgsql;
using GWS.Models;

namespace GWS.Repositories
{
    public class PeriksaRepository
    {
        public List<Periksa> GetAll()
        {
            var list = new List<Periksa>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM periksa", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Periksa
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    NamaPemeriksaan = reader["nama_pemeriksaan"].ToString()
                });
            }
            return list;
        }
        public void Insert(Periksa periksa)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("INSERT INTO periksa (nama_pemeriksaan, deskripsi) VALUES (@nama, @deskripsi)", conn);
            cmd.Parameters.AddWithValue("@nama", periksa.NamaPemeriksaan);
            cmd.Parameters.AddWithValue("@deskripsi", periksa.Deskripsi);
            cmd.ExecuteNonQuery();
        }

        public void Update(Periksa periksa)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("UPDATE periksa SET nama_pemeriksaan = @nama, deskripsi = @deskripsi WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", periksa.Id);
            cmd.Parameters.AddWithValue("@nama", periksa.NamaPemeriksaan);
            cmd.Parameters.AddWithValue("@deskripsi", periksa.Deskripsi);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("DELETE FROM periksa WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }

    public class Periksa
    {
        public int Id { get; set; }
        public string NamaPemeriksaan { get; set; }
        public string Deskripsi { get; set; }
    }
}
