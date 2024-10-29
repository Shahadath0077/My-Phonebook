using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyPhoneBook
{
    public partial class AddContact : Form
    {
        MainForm mf = new MainForm();
        string uid;
        string updatedText;
        public AddContact()
        {
            InitializeComponent();        
        }
        public AddContact(string data, string updateText)
        {
            InitializeComponent();
            UpdateData(data, updateText);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            mf.LoadData();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //bool text = false;
            MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
            var db = mongoClient.GetDatabase("phonebookdb");
            var collection = db.GetCollection<phoneBookModel>("phonebook");

            if (txtName.Text!="" && txtAddress.Text!="" && txtEmail.Text!="" && txtPhoneNo.Text!="")
            {
                var addData = new phoneBookModel
                {                 
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    PhoneNo = txtPhoneNo.Text
                };
                if (updatedText=="Update")
                {
                    var filterBuilder = Builders<phoneBookModel>.Filter;
                    var filter = filterBuilder.Eq("_id", new ObjectId(uid));

                    var updateBuilder = Builders<phoneBookModel>.Update;
                    var update = updateBuilder.Set("Name", addData.Name)
                                              .Set("Address", addData.Address)
                                              .Set("Email", addData.Email)
                                              .Set("PhoneNo", addData.PhoneNo);

                    var result = collection.UpdateOne(filter, update);
                    MessageBox.Show("Record Updated Successfully!", "Message", (MessageBoxButtons.OK), MessageBoxIcon.Information);
                    //Thread.Sleep(500);
                    Task.Delay(500);
                }
                else
                {
                    collection.InsertOne(addData);
                    MessageBox.Show("Record Added Successfully!", "Message", (MessageBoxButtons.OK), MessageBoxIcon.Information);
                    //Thread.Sleep(500);
                    Task.Delay(500);
                }
                this.Close();             
            }
            else
            {
                MessageBox.Show("Please enter all the record details!", "Message", (MessageBoxButtons.OK), MessageBoxIcon.Information);
            }          
        }

        public void UpdateData(string data, string updateText)
        {
            updatedText = updateText;
            MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
            var db = mongoClient.GetDatabase("phonebookdb");
            var collection = db.GetCollection<phoneBookModel>("phonebook");

            var queryFilter = Builders<phoneBookModel>.Filter.Eq(s => s.Id, data);
            var phoneBookCollection= collection.Find(queryFilter).ToList();

            foreach (var phoneData in phoneBookCollection)
            {
                uid=phoneData.Id;
                txtName.Text = phoneData.Name;
                txtAddress.Text = phoneData.Address;
                txtEmail.Text = phoneData.Email;
                txtPhoneNo.Text = phoneData.PhoneNo;
            }
            btnSave.Text = updatedText;
            ShowDialog();
        }
    }
}
