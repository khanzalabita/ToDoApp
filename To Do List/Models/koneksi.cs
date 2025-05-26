using MySql.Data.MySqlClient;
using System.Data;
using To_Do_List.Models;

namespace To_Do_List.Models
{
    public class koneksi
    {
        private readonly string connString = "server=localhost;user=root;password=;database=aplikasi_todolist;";

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }
    }
}