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
using To_Do_List.Models;
using To_Do_List.Controllers;

namespace To_Do_List.Views
{
    public partial class Form1 : Form
    {
        Controller controller = new Controller();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            bool loginSukses = controller.LoginUser(username, password);

            if (loginSukses)
            {
                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 dashboard = new Form2();
                dashboard.Show();
                this.Hide(); // tutup form login
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
