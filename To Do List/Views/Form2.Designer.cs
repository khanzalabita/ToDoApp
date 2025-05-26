namespace To_Do_List.Views
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeadline = new System.Windows.Forms.TextBox();
            this.txtTugas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tugas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal Deadline";
            // 
            // txtDeadline
            // 
            this.txtDeadline.Location = new System.Drawing.Point(217, 134);
            this.txtDeadline.Name = "txtDeadline";
            this.txtDeadline.Size = new System.Drawing.Size(198, 26);
            this.txtDeadline.TabIndex = 2;
            // 
            // txtTugas
            // 
            this.txtTugas.Location = new System.Drawing.Point(217, 184);
            this.txtTugas.Name = "txtTugas";
            this.txtTugas.Size = new System.Drawing.Size(198, 26);
            this.txtTugas.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Judul Tugas";
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(601, 136);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(164, 76);
            this.txtDeskripsi.TabIndex = 6;
            this.txtDeskripsi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Deskripsi Tugas";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deadline,
            this.tugas,
            this.deskripsi});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 278);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(800, 172);
            this.dgv.TabIndex = 7;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(17, 235);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(103, 37);
            this.buttonSimpan.TabIndex = 8;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(235, 235);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(103, 37);
            this.buttonHapus.TabIndex = 9;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(126, 235);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(103, 37);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCari
            // 
            this.buttonCari.Location = new System.Drawing.Point(562, 235);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(103, 37);
            this.buttonCari.TabIndex = 11;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(358, 240);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(198, 26);
            this.txtCari.TabIndex = 12;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(685, 235);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(103, 37);
            this.buttonLogOut.TabIndex = 13;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // deadline
            // 
            this.deadline.HeaderText = "Deadline";
            this.deadline.MinimumWidth = 8;
            this.deadline.Name = "deadline";
            this.deadline.ReadOnly = true;
            // 
            // tugas
            // 
            this.tugas.HeaderText = "Tugas";
            this.tugas.MinimumWidth = 8;
            this.tugas.Name = "tugas";
            this.tugas.ReadOnly = true;
            // 
            // deskripsi
            // 
            this.deskripsi.HeaderText = "Deskripsi";
            this.deskripsi.MinimumWidth = 8;
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTugas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeadline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeadline;
        private System.Windows.Forms.TextBox txtTugas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn tugas;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsi;
    }
}