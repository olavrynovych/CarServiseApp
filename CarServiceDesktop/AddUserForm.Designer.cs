using CarServiceApp;
using CarServiceApp.Models;
using System;

namespace CarServiceDesktop
{
    partial class AddUserForm
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

        private void CreateUser_button_Click(object sender, EventArgs e)
        {
            var clientInfo = new Client
            {
                FirstName = Name_textbox.Text,
                LastName = Surnname_textbox.Text,
                CellPhone = Phone_textbox.Text,
                Description = Details_textbox.Text
            };
            ;
            if (ClientValidator.IsValidClientInfo(clientInfo))
            {
                ClientHelper.InsertClientInfo(clientInfo);
                ClearForm();
                //show some notification to user
            }
            else
            {
                //MessageBox.Show("Customer ID was not returned. Account could not be created.");
            }
        }

        private void ClearForm()
        {
            Name_textbox.Clear();
            Surnname_textbox.Clear();
            Phone_textbox.Clear();
            Details_textbox.Clear();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateUser_button = new System.Windows.Forms.Button();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.Surnname_textbox = new System.Windows.Forms.TextBox();
            this.Phone_textbox = new System.Windows.Forms.TextBox();
            this.Details_textbox = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_details = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateUser_button
            // 
            this.CreateUser_button.Location = new System.Drawing.Point(243, 394);
            this.CreateUser_button.Name = "CreateUser_button";
            this.CreateUser_button.Size = new System.Drawing.Size(75, 23);
            this.CreateUser_button.TabIndex = 0;
            this.CreateUser_button.Text = "Create User";
            this.CreateUser_button.UseVisualStyleBackColor = true;
            this.CreateUser_button.Click += new EventHandler(CreateUser_button_Click);
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(152, 83);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(166, 20);
            this.Name_textbox.TabIndex = 1;
            // 
            // Surnname_textbox
            // 
            this.Surnname_textbox.Location = new System.Drawing.Point(152, 138);
            this.Surnname_textbox.Name = "Surnname_textbox";
            this.Surnname_textbox.Size = new System.Drawing.Size(166, 20);
            this.Surnname_textbox.TabIndex = 2;
            // 
            // Phone_textbox
            // 
            this.Phone_textbox.Location = new System.Drawing.Point(152, 195);
            this.Phone_textbox.Name = "Phone_textbox";
            this.Phone_textbox.Size = new System.Drawing.Size(166, 20);
            this.Phone_textbox.TabIndex = 3;
            // 
            // Details_textbox
            // 
            this.Details_textbox.Location = new System.Drawing.Point(152, 248);
            this.Details_textbox.Multiline = true;
            this.Details_textbox.Name = "Details_textbox";
            this.Details_textbox.Size = new System.Drawing.Size(166, 95);
            this.Details_textbox.TabIndex = 4;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(100, 90);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Name:";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(86, 145);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(52, 13);
            this.label_surname.TabIndex = 6;
            this.label_surname.Text = "Surname:";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(97, 202);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(41, 13);
            this.label_phone.TabIndex = 7;
            this.label_phone.Text = "Phone:";
            // 
            // label_details
            // 
            this.label_details.AutoSize = true;
            this.label_details.Location = new System.Drawing.Point(96, 248);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(42, 13);
            this.label_details.TabIndex = 8;
            this.label_details.Text = "Details:";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_details);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.Details_textbox);
            this.Controls.Add(this.Phone_textbox);
            this.Controls.Add(this.Surnname_textbox);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.CreateUser_button);
            this.Name = "AddUserForm";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateUser_button;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.TextBox Surnname_textbox;
        private System.Windows.Forms.TextBox Phone_textbox;
        private System.Windows.Forms.TextBox Details_textbox;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_details;
    }
}

