using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace To_Do_List
{
    public partial class Form1 : Form
    {
        // Ubah sesuai setting MySQL kamu
        private string connectionString = "server=localhost;database=aplikasi_todolist;uid=root;pwd=;";
        private MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Koneksi ke database MySQL berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi ke database GAGAL: " + ex.Message);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    // Login berhasil
                    MessageBox.Show("Login berhasil!");
                    Form2 F2 = new Form2();
                    F2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah.");
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}
