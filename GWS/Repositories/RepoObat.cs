using System.Collections.Generic;
using GWS.Models;
using Npgsql;

namespace GWS.Repositories
{
    public class ObatRepository
    {
        public List<Obat> GetAll()
        {
            var list = new List<Obat>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM obat", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Obat
                {
                    Id = (int)reader["id"],
                    Nama = reader["nama"].ToString(),
                    Stok = (int)reader["stok"],
                    Keterangan = reader["keterangan"].ToString()
                });
            }
            return list;
        }

        public void Insert(Obat obat)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("INSERT INTO obat (nama, stok, keterangan) VALUES (@nama, @stok, @keterangan)", conn);
            cmd.Parameters.AddWithValue("@nama", obat.Nama);
            cmd.Parameters.AddWithValue("@stok", obat.Stok);
            cmd.Parameters.AddWithValue("@keterangan", obat.Keterangan);
            cmd.ExecuteNonQuery();
        }

        public void Update(Obat obat)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("UPDATE obat SET nama = @nama, stok = @stok, keterangan = @keterangan WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obat.Id);
            cmd.Parameters.AddWithValue("@nama", obat.Nama);
            cmd.Parameters.AddWithValue("@stok", obat.Stok);
            cmd.Parameters.AddWithValue("@keterangan", obat.Keterangan);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("DELETE FROM obat WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
