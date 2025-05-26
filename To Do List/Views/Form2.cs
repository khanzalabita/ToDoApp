using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using To_Do_List.Models;
using To_Do_List.Controllers;

namespace To_Do_List.Views
{
    public partial class Form2 : Form
    {
        private CRUD crud = new CRUD();
        private int selectedId = -1;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgv.CellClick += dgv_CellClick;
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            DataTable dt = crud.LoadTugas();
            dgv.DataSource = null; // Reset datasource
            dgv.DataSource = dt;

            if (dgv.Columns.Contains("id")) dgv.Columns["id"].Visible = false;
            if (dgv.Columns.Contains("due_date")) dgv.Columns["due_date"].HeaderText = "Deadline";
            if (dgv.Columns.Contains("title")) dgv.Columns["title"].HeaderText = "Tugas";
            if (dgv.Columns.Contains("description")) dgv.Columns["description"].HeaderText = "Deskripsi";

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.ClearSelection();
        }

        private void ResetForm()
        {
            txtDeadline.Clear();
            txtTugas.Clear();
            txtDeskripsi.Clear();
            selectedId = -1;
            dgv.ClearSelection();
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

            crud.TambahTugas(deadline, tugas, deskripsi);

            MessageBox.Show("Tugas berhasil disimpan!");
            LoadDataToGrid();
            ResetForm();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            SimpanDataKeDatabase();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv.Rows[e.RowIndex].Cells["id"].Value != null)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["id"].Value);
                txtDeadline.Text = row.Cells["due_date"].Value?.ToString();
                txtTugas.Text = row.Cells["title"].Value?.ToString();
                txtDeskripsi.Text = row.Cells["description"].Value?.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectedId != -1)
            {
                string deadline = txtDeadline.Text.Trim();
                string tugas = txtTugas.Text.Trim();
                string deskripsi = txtDeskripsi.Text.Trim();

                if (string.IsNullOrWhiteSpace(deadline) || string.IsNullOrWhiteSpace(tugas))
                {
                    MessageBox.Show("Deadline dan Tugas wajib diisi untuk mengedit!");
                    return;
                }

                // Update data ke database
                crud.UpdateTugas(selectedId, deadline, tugas, deskripsi);
                MessageBox.Show("Tugas berhasil diupdate!");

                // Update data di DataGridView tanpa reload ulang data
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells["id"].Value != null && (int)row.Cells["id"].Value == selectedId)
                    {
                        row.Cells["due_date"].Value = deadline;
                        row.Cells["title"].Value = tugas;
                        row.Cells["description"].Value = deskripsi;
                        break;
                    }
                }

                ResetForm();
            }
            else
            {
                MessageBox.Show("Pilih tugas yang ingin diedit terlebih dahulu.");
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (selectedId != -1)
            {
                DialogResult result = MessageBox.Show("Yakin ingin menghapus tugas ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    crud.HapusTugas(selectedId);
                    MessageBox.Show("Tugas berhasil dihapus!");
                    LoadDataToGrid();
                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show("Pilih tugas yang ingin dihapus terlebih dahulu.");
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim().ToLower();
            DataView dv = crud.LoadTugas().DefaultView;
            dv.RowFilter = $"title LIKE '%{keyword}%' OR description LIKE '%{keyword}%'";
            dgv.DataSource = dv;
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            buttonCari_Click(sender, e);
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda berhasil logout.");
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Kosong sesuai desain awal
        }
    }
}