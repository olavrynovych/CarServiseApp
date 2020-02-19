using CarServiceApp;
using CarServiceApp.Models;
using System;
using System.Threading;

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
            if (!ClientValidator.ValidateFirstOrSecondName(clientInfo.FirstName))
            {
                NameErrorProvider.SetError(Name_textbox, "Name is not correct.");
            }
            if (!ClientValidator.ValidateFirstOrSecondName(clientInfo.LastName))
            {
                SecondNameErrorProvider.SetError(Surnname_textbox, "Second name is not correct.");
            }
            if (!ClientValidator.ValidatePhoneNumber(clientInfo.CellPhone, true))
            {
                PhoneNumberErrorProvider.SetError(Phone_textbox, $"Phone number is not correct.{Environment.NewLine}It should contain 10 digits.");
            }
            if (ClientValidator.IsValidClientInfo(clientInfo))
            {
                ClientHelper.InsertClientInfo(clientInfo);
                ClearForm();
                MessageLabel.Show();
                MessageLabel.Text = "Client info was successfully saved!";
                //Thread.Sleep(2000);//queeck dummy way))) TODO: change!
                //MessageLabel.Text = string.Empty;
            }
        }

        private void ClearForm_button_Click(object sender, EventArgs e)
        {
            ClearForm();
            NameErrorProvider.Clear();
            SecondNameErrorProvider.Clear();
            PhoneNumberErrorProvider.Clear();
            MessageLabel.Hide();
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
            this.components = new System.ComponentModel.Container();
            this.CreateUser_button = new System.Windows.Forms.Button();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.Surnname_textbox = new System.Windows.Forms.TextBox();
            this.Phone_textbox = new System.Windows.Forms.TextBox();
            this.Details_textbox = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_details = new System.Windows.Forms.Label();
            this.NameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SecondNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PhoneNumberErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ClearFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateUser_button
            // 
            this.CreateUser_button.Location = new System.Drawing.Point(251, 335);
            this.CreateUser_button.Name = "CreateUser_button";
            this.CreateUser_button.Size = new System.Drawing.Size(75, 23);
            this.CreateUser_button.TabIndex = 0;
            this.CreateUser_button.Text = "Create User";
            this.CreateUser_button.UseVisualStyleBackColor = true;
            this.CreateUser_button.Click += new System.EventHandler(this.CreateUser_button_Click);
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(85, 25);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(241, 20);
            this.Name_textbox.TabIndex = 1;
            // 
            // Surnname_textbox
            // 
            this.Surnname_textbox.Location = new System.Drawing.Point(85, 80);
            this.Surnname_textbox.Name = "Surnname_textbox";
            this.Surnname_textbox.Size = new System.Drawing.Size(241, 20);
            this.Surnname_textbox.TabIndex = 2;
            // 
            // Phone_textbox
            // 
            this.Phone_textbox.Location = new System.Drawing.Point(85, 137);
            this.Phone_textbox.Name = "Phone_textbox";
            this.Phone_textbox.Size = new System.Drawing.Size(241, 20);
            this.Phone_textbox.TabIndex = 3;
            // 
            // Details_textbox
            // 
            this.Details_textbox.Location = new System.Drawing.Point(85, 190);
            this.Details_textbox.Multiline = true;
            this.Details_textbox.Name = "Details_textbox";
            this.Details_textbox.Size = new System.Drawing.Size(241, 95);
            this.Details_textbox.TabIndex = 4;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(33, 32);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Name:";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(19, 87);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(52, 13);
            this.label_surname.TabIndex = 6;
            this.label_surname.Text = "Surname:";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(30, 144);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(41, 13);
            this.label_phone.TabIndex = 7;
            this.label_phone.Text = "Phone:";
            // 
            // label_details
            // 
            this.label_details.AutoSize = true;
            this.label_details.Location = new System.Drawing.Point(29, 190);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(42, 13);
            this.label_details.TabIndex = 8;
            this.label_details.Text = "Details:";
            // 
            // NameErrorProvider
            // 
            this.NameErrorProvider.ContainerControl = this;
            // 
            // SecondNameErrorProvider
            // 
            this.SecondNameErrorProvider.ContainerControl = this;
            // 
            // PhoneNumberErrorProvider
            // 
            this.PhoneNumberErrorProvider.ContainerControl = this;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.MessageLabel.Location = new System.Drawing.Point(121, 388);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(205, 13);
            this.MessageLabel.TabIndex = 9;
            this.MessageLabel.Text = "Client info was successfully saved!";
            this.MessageLabel.Visible = false;
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Location = new System.Drawing.Point(85, 335);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(75, 23);
            this.ClearFormButton.TabIndex = 10;
            this.ClearFormButton.Text = "Clear Form";
            this.ClearFormButton.UseVisualStyleBackColor = true;
            this.ClearFormButton.Click += new System.EventHandler(this.ClearForm_button_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 419);
            this.Controls.Add(this.ClearFormButton);
            this.Controls.Add(this.MessageLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberErrorProvider)).EndInit();
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
        private System.Windows.Forms.ErrorProvider NameErrorProvider;
        private System.Windows.Forms.ErrorProvider SecondNameErrorProvider;
        private System.Windows.Forms.ErrorProvider PhoneNumberErrorProvider;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button ClearFormButton;
    }
}

