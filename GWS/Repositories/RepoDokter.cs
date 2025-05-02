using System;
using System.Collections.Generic;
using GWS.Models;
using Npgsql;

namespace GWS.Repositories
{
    public class DokterRepository
    {
        public List<Dokter> GetAll()
        {
            var list = new List<Dokter>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM dokter", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Dokter
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Nama = reader["nama"].ToString(),
                    Spesialis = reader["spesialis"].ToString(),
                    Username = reader["username"].ToString(),
                    Password = reader["password"].ToString(),
                    Role = reader["role"].ToString()
                });
            }
            return list;
        }

        public void Insert(Dokter dokter)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("INSERT INTO dokter (nama, spesialis, username, password, role) VALUES (@nama, @spesialis, @username, @password, @role)", conn);
            cmd.Parameters.AddWithValue("@nama", dokter.Nama);
            cmd.Parameters.AddWithValue("@spesialis", dokter.Spesialis);
            cmd.Parameters.AddWithValue("@username", dokter.Username);
            cmd.Parameters.AddWithValue("@password", dokter.Password);
            cmd.Parameters.AddWithValue("@role", dokter.Role);
            cmd.ExecuteNonQuery();
        }

        public void Update(Dokter dokter)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("UPDATE dokter SET nama = @nama, spesialis = @spesialis, username = @username, password = @password WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", dokter.Id);
            cmd.Parameters.AddWithValue("@nama", dokter.Nama);
            cmd.Parameters.AddWithValue("@spesialis", dokter.Spesialis);
            cmd.Parameters.AddWithValue("@username", dokter.Username);
            cmd.Parameters.AddWithValue("@password", dokter.Password);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("DELETE FROM dokter WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}