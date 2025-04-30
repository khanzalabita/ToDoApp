using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form2 : Form
    {
        private string connectionString = "server=localhost;database=aplikasi_todolist;uid=root;pwd=;";
        private MySqlConnection connection;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            LoadDataToGrid(); // Menampilkan data saat form dibuka
            dgv.CellClick += dgv_CellClick; // Event klik pada grid
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Boleh kosong jika tidak digunakan
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deadline = txtDeadline.Text.Trim();
            string tugas = txtTugas.Text.Trim();
            string deskripsi = txtDeskripsi.Text.Trim();

            if (string.IsNullOrWhiteSpace(deadline) || string.IsNullOrWhiteSpace(tugas))
            {
                MessageBox.Show("Deadline dan Tugas wajib diisi!");
                return;
            }

            try
            {
                connection.Open();

                string query = "INSERT INTO tasks (due_date, title, description) VALUES (@deadline, @tugas, @deskripsi)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@deadline", deadline);
                cmd.Parameters.AddWithValue("@tugas", tugas);
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Tugas berhasil disimpan!");
                    txtDeadline.Clear();
                    txtTugas.Clear();
                    txtDeskripsi.Clear();
                    LoadDataToGrid(); // Refresh isi DataGridView setelah simpan
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan tugas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadDataToGrid()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "SELECT id, due_date AS 'Deadline', title AS 'Tugas', description AS 'Deskripsi' FROM tasks";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgv.Columns.Clear();
                dgv.DataSource = dt;
                dgv.AllowUserToAddRows = false;
                dgv.RowHeadersVisible = false;
                dgv.Columns["id"].Visible = false; // jika ada kolom ID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void SimpanDataKeDatabase()
        {
            string deadline = txtDeadline.Text.Trim();
            string tugas = txtTugas.Text.Trim();
            string deskripsi = txtDeskripsi.Text.Trim();

            if (string.IsNullOrWhiteSpace(deadline) || string.IsNullOrWhiteSpace(tugas))
            {
                MessageBox.Show("Deadline dan Tugas wajib diisi!");
                return;
            }

            try
            {
                connection.Open();

                string query = "INSERT INTO tasks (due_date, title, description) VALUES (@deadline, @tugas, @deskripsi)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@deadline", deadline);
                cmd.Parameters.AddWithValue("@tugas", tugas);
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Tugas berhasil disimpan!");
                    txtDeadline.Clear();
                    txtTugas.Clear();
                    txtDeskripsi.Clear();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan tugas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            SimpanDataKeDatabase();
            LoadDataToGrid();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                txtDeadline.Text = row.Cells["Deadline"].Value.ToString();
                txtTugas.Text = row.Cells["Tugas"].Value.ToString();
                txtDeskripsi.Text = row.Cells["Deskripsi"].Value.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                string id = dgv.CurrentRow.Cells["id"].Value.ToString();
                string deadline = txtDeadline.Text.Trim();
                string tugas = txtTugas.Text.Trim();
                string deskripsi = txtDeskripsi.Text.Trim();

                if (string.IsNullOrWhiteSpace(deadline) || string.IsNullOrWhiteSpace(tugas))
                {
                    MessageBox.Show("Deadline dan Tugas wajib diisi!");
                    return;
                }

                try
                {
                    connection.Open();
                    string query = "UPDATE tasks SET due_date = @deadline, title = @tugas, description = @deskripsi WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@deadline", deadline);
                    cmd.Parameters.AddWithValue("@tugas", tugas);
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
                    cmd.Parameters.AddWithValue("@id", id);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Tugas berhasil diupdate!");
                        LoadDataToGrid();
                        txtDeadline.Clear();
                        txtTugas.Clear();
                        txtDeskripsi.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengupdate tugas.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kesalahan: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Yakin ingin menghapus tugas ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string id = dgv.CurrentRow.Cells["id"].Value.ToString();

                    try
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        string query = "DELETE FROM tasks WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Tugas berhasil dihapus!");
                            LoadDataToGrid(); // refresh tampilan tabel
                            txtDeadline.Clear();
                            txtTugas.Clear();
                            txtDeskripsi.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus tugas.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kesalahan: " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

    }
}