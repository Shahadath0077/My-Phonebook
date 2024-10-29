namespace MyPhoneBook
{
    partial class AddContact
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
            btnSave = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNo = new TextBox();
            groupBox1 = new GroupBox();
            txtAddress = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSave.Location = new Point(27, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 39);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnClose.Location = new Point(266, 306);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 39);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(23, 35);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(23, 73);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 3;
            label2.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(23, 170);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 4;
            label3.Text = "E-Mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(23, 217);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 5;
            label4.Text = "Phone No:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(115, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 29);
            txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(115, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 29);
            txtEmail.TabIndex = 8;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Font = new Font("Segoe UI", 12F);
            txtPhoneNo.Location = new Point(115, 210);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(223, 29);
            txtPhoneNo.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPhoneNo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(27, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 262);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Details";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(115, 71);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(223, 81);
            txtAddress.TabIndex = 10;
            txtAddress.Text = "";
            // 
            // AddContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(415, 378);
            Controls.Add(groupBox1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddContact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Contact";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhoneNo;
        private GroupBox groupBox1;
        private RichTextBox txtAddress;
    }
}