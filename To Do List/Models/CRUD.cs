using System.Data;
using MySql.Data.MySqlClient;

namespace To_Do_List.Models
{
    public class CRUD : koneksi
    {
        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM users WHERE username = @username AND password = @password";

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows; // Jika ditemukan baris, berarti login berhasil
                    }
                }
            }
        }

        public DataTable LoadTugas()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tasks";

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public void TambahTugas(string deadline, string tugas, string deskripsi)
        {
            string query = "INSERT INTO tasks (due_date, title, description) VALUES (@deadline, @tugas, @deskripsi)";

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@deadline", deadline);
                    cmd.Parameters.AddWithValue("@tugas", tugas);
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTugas(int id, string deadline, string tugas, string deskripsi)
        {
            string query = "UPDATE tasks SET due_date = @deadline, title = @tugas, description = @deskripsi WHERE id = @id";

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@deadline", deadline);
                    cmd.Parameters.AddWithValue("@tugas", tugas);
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void HapusTugas(int id)
        {
            string query = "DELETE FROM tasks WHERE id = @id";

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
