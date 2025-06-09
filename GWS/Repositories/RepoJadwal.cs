using System.Collections.Generic;
using GWS.Models;
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

            string query = @"
        SELECT j.id, j.hari, j.jam, j.dokter_id, d.nama AS nama_dokter
        FROM jadwal j
        JOIN dokter d ON j.dokter_id = d.id
        ORDER BY j.id";

            using var cmd = new NpgsqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Jadwal
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Hari = reader["hari"].ToString(),
                    Jam = reader["jam"].ToString(),
                    DokterId = reader.GetInt32(reader.GetOrdinal("dokter_id")),
                    Dokter = reader["nama_dokter"].ToString() 
                });
            }
            return list;
        }


        public void Insert(Jadwal jadwal)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "INSERT INTO jadwal (hari, jam, dokter_id) VALUES (@hari, @jam, @dokter_id)", conn);
            cmd.Parameters.AddWithValue("@hari", jadwal.Hari);
            cmd.Parameters.AddWithValue("@jam", jadwal.Jam);
            cmd.Parameters.AddWithValue("@dokter_id", jadwal.DokterId);
            cmd.ExecuteNonQuery();
        }

        public void Update(Jadwal jadwal)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE jadwal SET hari = @hari, jam = @jam, dokter_id = @dokter_id WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", jadwal.Id);
            cmd.Parameters.AddWithValue("@hari", jadwal.Hari);
            cmd.Parameters.AddWithValue("@jam", jadwal.Jam);
            cmd.Parameters.AddWithValue("@dokter_id", jadwal.DokterId);
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
