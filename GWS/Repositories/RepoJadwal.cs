using System;
using System.Collections.Generic;
using GWS.Models; // pastikan ada ini
using Npgsql;

namespace GWS.Repositories
{
    public class JadwalReposit
    {
        public List<Jadwal> GetAll()
        {
            var list = new List<Jadwal>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM jadwal", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Jadwal
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Hari = reader["hari"].ToString(),
                    Jam = reader["jam"].ToString(),
                    Dokter = reader["dokter"].ToString()
                });
            }
            return list;
        }

        public void Insert(Jadwal jadwal)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "INSERT INTO jadwal (hari, jam, dokter) VALUES (@hari, @jam, @dokter)", conn);
            cmd.Parameters.AddWithValue("@hari", jadwal.Hari);
            cmd.Parameters.AddWithValue("@jam", jadwal.Jam);
            cmd.Parameters.AddWithValue("@dokter", jadwal.Dokter);
            cmd.ExecuteNonQuery();
        }

        public void Update(Jadwal jadwal)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE jadwal SET hari = @hari, jam = @jam, dokter = @dokter WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", jadwal.Id);
            cmd.Parameters.AddWithValue("@hari", jadwal.Hari);
            cmd.Parameters.AddWithValue("@jam", jadwal.Jam);
            cmd.Parameters.AddWithValue("@dokter", jadwal.Dokter);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("DELETE FROM jadwal WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
