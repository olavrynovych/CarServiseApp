using CarServiceApp;
using CarServiceApp.Models;
using System;

namespace CarServiceDesktop
{
    partial class AddEmployeeForm
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


        private void CreateEmployee_button_Click(object sender, EventArgs e)
        {
            var employeeInfo = new Employee
            {
                FirstName = Name_textbox.Text,
                LastName = Surnname_textbox.Text,
                Phone = Phone_textbox.Text,
                Description = Details_textbox.Text
            };
            ;
            if (!EmployeeValidator.ValidateFirstOrSecondName(employeeInfo.FirstName))
            {
                NameErrorProvider.SetError(Name_textbox, "Name is not correct.");
            }
            if (!EmployeeValidator.ValidateFirstOrSecondName(employeeInfo.LastName))
            {
                SecondNameErrorProvider.SetError(Surnname_textbox, "Second name is not correct.");
            }
            if (!EmployeeValidator.ValidatePhoneNumber(employeeInfo.Phone, true))
            {
                PhoneNumberErrorProvider.SetError(Phone_textbox, $"Phone number is not correct.{Environment.NewLine}It should contain 10 digits.");
            }
            if (EmployeeValidator.IsValidClientInfo(employeeInfo))
            {
                EmployeeHelper.InsertEmployeeInfo(employeeInfo);
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
            this.ClearFormButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.label_details = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.Details_textbox = new System.Windows.Forms.TextBox();
            this.Phone_textbox = new System.Windows.Forms.TextBox();
            this.Surnname_textbox = new System.Windows.Forms.TextBox();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.CreateEmployee_button = new System.Windows.Forms.Button();
            this.NameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SecondNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PhoneNumberErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Location = new System.Drawing.Point(181, 316);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(89, 23);
            this.ClearFormButton.TabIndex = 21;
            this.ClearFormButton.Text = "Clear Form";
            this.ClearFormButton.UseVisualStyleBackColor = true;
            this.ClearFormButton.Click += new EventHandler(ClearForm_button_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.MessageLabel.Location = new System.Drawing.Point(217, 369);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(227, 13);
            this.MessageLabel.TabIndex = 20;
            this.MessageLabel.Text = "Employee info was successfully saved!";
            this.MessageLabel.Visible = false;
            // 
            // label_details
            // 
            this.label_details.AutoSize = true;
            this.label_details.Location = new System.Drawing.Point(125, 171);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(42, 13);
            this.label_details.TabIndex = 19;
            this.label_details.Text = "Details:";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(126, 125);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(41, 13);
            this.label_phone.TabIndex = 18;
            this.label_phone.Text = "Phone:";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(115, 68);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(52, 13);
            this.label_surname.TabIndex = 17;
            this.label_surname.Text = "Surname:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(129, 13);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 16;
            this.label_name.Text = "Name:";
            // 
            // Details_textbox
            // 
            this.Details_textbox.Location = new System.Drawing.Point(181, 171);
            this.Details_textbox.Multiline = true;
            this.Details_textbox.Name = "Details_textbox";
            this.Details_textbox.Size = new System.Drawing.Size(241, 95);
            this.Details_textbox.TabIndex = 15;
            // 
            // Phone_textbox
            // 
            this.Phone_textbox.Location = new System.Drawing.Point(181, 118);
            this.Phone_textbox.Name = "Phone_textbox";
            this.Phone_textbox.Size = new System.Drawing.Size(241, 20);
            this.Phone_textbox.TabIndex = 14;
            // 
            // Surnname_textbox
            // 
            this.Surnname_textbox.Location = new System.Drawing.Point(181, 61);
            this.Surnname_textbox.Name = "Surnname_textbox";
            this.Surnname_textbox.Size = new System.Drawing.Size(241, 20);
            this.Surnname_textbox.TabIndex = 13;
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(181, 6);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(241, 20);
            this.Name_textbox.TabIndex = 12;
            // 
            // CreateEmployee_button
            // 
            this.CreateEmployee_button.Location = new System.Drawing.Point(326, 316);
            this.CreateEmployee_button.Name = "CreateEmployee_button";
            this.CreateEmployee_button.Size = new System.Drawing.Size(96, 23);
            this.CreateEmployee_button.TabIndex = 11;
            this.CreateEmployee_button.Text = "Create Employee";
            this.CreateEmployee_button.UseVisualStyleBackColor = true;
            this.CreateEmployee_button.Click += new EventHandler(CreateEmployee_button_Click);
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
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 389);
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
            this.Controls.Add(this.CreateEmployee_button);
            this.Name = "AddEmployeeForm";
            this.Text = "Add Employee Form";
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearFormButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label label_details;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox Details_textbox;
        private System.Windows.Forms.TextBox Phone_textbox;
        private System.Windows.Forms.TextBox Surnname_textbox;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.Button CreateEmployee_button;
        private System.Windows.Forms.ErrorProvider NameErrorProvider;
        private System.Windows.Forms.ErrorProvider SecondNameErrorProvider;
        private System.Windows.Forms.ErrorProvider PhoneNumberErrorProvider;
    }
}