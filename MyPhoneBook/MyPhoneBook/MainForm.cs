
using Microsoft.VisualBasic;
using MongoDB.Driver;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyPhoneBook
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddContact addContact = new AddContact();
            addContact.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public async Task LoadData()
        {
            MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
            var db = mongoClient.GetDatabase("phonebookdb");
            var collection = db.GetCollection<phoneBookModel>("phonebook");
            var filter = Builders<phoneBookModel>.Filter.Empty;
            var showData = collection.Find(filter).ToList();
            dgvPhoneBook.DataSource = showData;
            dgvPhoneBook.ClearSelection();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();          
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();           
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateText = "Update";

            if (dgvPhoneBook.SelectedRows.Count > 0)
            {
                string data = dgvPhoneBook.CurrentRow.Cells[0].Value.ToString();
                AddContact addContact = new AddContact(data, updateText);
            }
            else
            {
                MessageBox.Show("Please select a record to update!", "Message", (MessageBoxButtons.OK),MessageBoxIcon.Information);
            }
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPhoneBook.SelectedRows.Count > 0)
            {
                string id = dgvPhoneBook.CurrentRow.Cells[0].Value.ToString();
                MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
                var db = mongoClient.GetDatabase("phonebookdb");
                var collection = db.GetCollection<phoneBookModel>("phonebook");

                // Prompt user yes/no option to delete the record
                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                //switch (dialogResult)
                //{
                //    case DialogResult.Yes:
                //        collection.DeleteOne(a => a.Id == id);
                //        await LoadData();
                //        Thread.Sleep(300);
                //        MessageBox.Show("Record Deleted Successfully!", "Message",   (MessageBoxButtons.OK), MessageBoxIcon.Information);
                //        break;
                //    case DialogResult.No:
                //        break;
                //}

                if (dialogResult == DialogResult.Yes)
                {    
                    // delete the record
                    collection.DeleteOne(a => a.Id == id);
                    await LoadData();
                    Thread.Sleep(300);
                    // show the message dialog 
                    MessageBox.Show("Record Deleted Successfully!", "Message", (MessageBoxButtons.OK), MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
                {
                    // close the message dialog
                    this.DialogResult = DialogResult.No;                
                }
            }
            else
            {       
                // show message to select a record
                MessageBox.Show("Please select a record to delete!", "Message", (MessageBoxButtons.OK), MessageBoxIcon.Information);
            }
        }
    }
}
