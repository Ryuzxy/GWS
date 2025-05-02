using GWS.Models;
using Npgsql;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

public class DatabaseHelper
{
    public static NpgsqlConnection GetConnection()
    {
        string connString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        return new NpgsqlConnection(connString);
    }


    public User CheckLogin(string username, string password)
    {
        using (var conn = GetConnection())  // Corrected this line
        {
            conn.Open();
            // Query untuk mengambil username dan password hash
            string query = "SELECT id, username, password, role FROM users WHERE username = @username";
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("username", username);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedPasswordHash = reader["password"].ToString();
                        string storedUsername = reader["username"].ToString();
                        int userId = (int)reader["id"];
                        string userRole = reader["role"].ToString();

                        // Verifikasi password dengan hash yang ada
                        if (VerifyPasswordHash(password, storedPasswordHash))
                        {
                            return new User
                            {
                                Id = userId,
                                Username = storedUsername,
                                Role = userRole
                            };
                        }
                    }
                }
            }
        }
        return null; // Jika login gagal
    }
    private bool VerifyPasswordHash(string password, string storedHash)
    {
        string hashedPassword = HashPassword(password); // Hash password yang dimasukkan
        return hashedPassword == storedHash; // Bandingkan dengan hash yang ada di DB
    }

    private string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }
    }
}
