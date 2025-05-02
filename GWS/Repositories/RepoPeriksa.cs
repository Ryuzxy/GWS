using System.Collections.Generic;
using Npgsql;

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
    }

    public class Periksa
    {
        public int Id { get; set; }
        public string NamaPemeriksaan { get; set; }
    }
}
