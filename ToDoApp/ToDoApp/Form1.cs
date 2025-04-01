using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class Form1 : Form
    {
        private List<string> tasks = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                tasks.Add(txtTask.Text);
                UpdateTaskList();
                txtTask.Clear();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                string updatedTask = txtTask.Text;
                if (!string.IsNullOrWhiteSpace(updatedTask))
                {
                    tasks[lstTasks.SelectedIndex] = updatedTask;
                    UpdateTaskList();
                    txtTask.Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                tasks.RemoveAt(lstTasks.SelectedIndex);
                UpdateTaskList();
            }
        }

        private void UpdateTaskList()
        {
            lstTasks.DataSource = null;
            lstTasks.DataSource = tasks;
        }
    }
}