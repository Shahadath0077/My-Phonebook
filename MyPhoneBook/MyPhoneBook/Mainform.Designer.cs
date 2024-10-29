namespace MyPhoneBook
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            dgvPhoneBook = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPhoneBook).BeginInit();
            SuspendLayout();
            // 
            // btnAddNew
            // 
            btnAddNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddNew.Location = new Point(38, 356);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(126, 49);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.Location = new Point(353, 356);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 49);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.Location = new Point(662, 356);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(126, 49);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(514, 356);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 49);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(192, 356);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(126, 47);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Refresh";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvPhoneBook
            // 
            dgvPhoneBook.AllowUserToAddRows = false;
            dgvPhoneBook.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Beige;
            dgvPhoneBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPhoneBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhoneBook.BackgroundColor = Color.WhiteSmoke;
            dgvPhoneBook.BorderStyle = BorderStyle.None;
            dgvPhoneBook.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPhoneBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhoneBook.Location = new Point(39, 12);
            dgvPhoneBook.MultiSelect = false;
            dgvPhoneBook.Name = "dgvPhoneBook";
            dgvPhoneBook.ReadOnly = true;
            dgvPhoneBook.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhoneBook.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvPhoneBook.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhoneBook.RowTemplate.ReadOnly = true;
            dgvPhoneBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhoneBook.Size = new Size(750, 326);
            dgvPhoneBook.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(831, 432);
            Controls.Add(dgvPhoneBook);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Phone Book";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhoneBook).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnExit;
        private Button btnDelete;
        private Button btnLoad;
        public DataGridView dgvPhoneBook;
    }
}
