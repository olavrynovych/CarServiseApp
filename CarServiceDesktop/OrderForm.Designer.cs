using CarServiceApp;

namespace CarServiceDesktop
{
    partial class OrderForm
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
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.AppointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OrderDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.IssuesWithCarLabel = new System.Windows.Forms.Label();
            this.EmployeeToFixLabel = new System.Windows.Forms.Label();
            this.IssuesWithCarTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentDateLabel = new System.Windows.Forms.Label();
            this.EmployeeToFixComboBox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.OrderDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Location = new System.Drawing.Point(603, 390);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(165, 23);
            this.CreateOrderButton.TabIndex = 0;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // AppointmentDateTimePicker
            // 
            this.AppointmentDateTimePicker.Location = new System.Drawing.Point(169, 37);
            this.AppointmentDateTimePicker.Name = "AppointmentDateTimePicker";
            this.AppointmentDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.AppointmentDateTimePicker.TabIndex = 1;
            // 
            // OrderDetailsGroupBox
            // 
            this.OrderDetailsGroupBox.Controls.Add(this.CustomerComboBox);
            this.OrderDetailsGroupBox.Controls.Add(this.CustomerLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.IssuesWithCarLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.EmployeeToFixLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.IssuesWithCarTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.AppointmentDateLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.EmployeeToFixComboBox);
            this.OrderDetailsGroupBox.Controls.Add(this.AppointmentDateTimePicker);
            this.OrderDetailsGroupBox.Location = new System.Drawing.Point(12, 35);
            this.OrderDetailsGroupBox.Name = "OrderDetailsGroupBox";
            this.OrderDetailsGroupBox.Size = new System.Drawing.Size(397, 305);
            this.OrderDetailsGroupBox.TabIndex = 2;
            this.OrderDetailsGroupBox.TabStop = false;
            this.OrderDetailsGroupBox.Text = "Order Details";
            this.OrderDetailsGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(169, 223);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(199, 21);
            this.CustomerComboBox.TabIndex = 10;
            this.InitClientData();
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(27, 223);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(51, 13);
            this.CustomerLabel.TabIndex = 9;
            this.CustomerLabel.Text = "Customer";
            // 
            // IssuesWithCarLabel
            // 
            this.IssuesWithCarLabel.AutoSize = true;
            this.IssuesWithCarLabel.Location = new System.Drawing.Point(27, 133);
            this.IssuesWithCarLabel.Name = "IssuesWithCarLabel";
            this.IssuesWithCarLabel.Size = new System.Drawing.Size(77, 13);
            this.IssuesWithCarLabel.TabIndex = 7;
            this.IssuesWithCarLabel.Text = "Issues with car";
            // 
            // EmployeeToFixLabel
            // 
            this.EmployeeToFixLabel.AutoSize = true;
            this.EmployeeToFixLabel.Location = new System.Drawing.Point(26, 78);
            this.EmployeeToFixLabel.Name = "EmployeeToFixLabel";
            this.EmployeeToFixLabel.Size = new System.Drawing.Size(78, 13);
            this.EmployeeToFixLabel.TabIndex = 6;
            this.EmployeeToFixLabel.Text = "Employee to fix";
            // 
            // IssuesWithCarTextBox
            // 
            this.IssuesWithCarTextBox.Location = new System.Drawing.Point(169, 133);
            this.IssuesWithCarTextBox.Multiline = true;
            this.IssuesWithCarTextBox.Name = "IssuesWithCarTextBox";
            this.IssuesWithCarTextBox.Size = new System.Drawing.Size(199, 56);
            this.IssuesWithCarTextBox.TabIndex = 5;
            // 
            // AppointmentDateLabel
            // 
            this.AppointmentDateLabel.AutoSize = true;
            this.AppointmentDateLabel.Location = new System.Drawing.Point(26, 37);
            this.AppointmentDateLabel.Name = "AppointmentDateLabel";
            this.AppointmentDateLabel.Size = new System.Drawing.Size(103, 13);
            this.AppointmentDateLabel.TabIndex = 3;
            this.AppointmentDateLabel.Text = "Date of appointment";
            // 
            // EmployeeToFixComboBox
            // 
            this.EmployeeToFixComboBox.FormattingEnabled = true;
            this.EmployeeToFixComboBox.Location = new System.Drawing.Point(169, 78);
            this.EmployeeToFixComboBox.Name = "EmployeeToFixComboBox";
            this.EmployeeToFixComboBox.Size = new System.Drawing.Size(199, 21);
            this.EmployeeToFixComboBox.TabIndex = 2;
            this.InitEmployeeData();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(582, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderDetailsGroupBox);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.textBox2);
            this.Name = "OrderForm";
            this.Text = "Order Form";
            this.OrderDetailsGroupBox.ResumeLayout(false);
            this.OrderDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private void InitEmployeeData()
        {
            var data = EmployeeHelper.GetEmployees();
            //this.EmployeeToFixComboBox.DataSource = data;
            foreach (var item in data)
            {
                var fullName = $"{item.LastName} {item.FirstName}";
                this.EmployeeToFixComboBox.ValueMember = item.Id.ToString();
                this.EmployeeToFixComboBox.DisplayMember = fullName;
                this.EmployeeToFixComboBox.Items.Add(fullName);

            }
            //this.EmployeeToFixComboBox.DisplayMember = "employeeName employeeSecondName";
        }

        private void InitClientData()
        {
            var data = ClientHelper.GetCustomers();
            //this.EmployeeToFixComboBox.DataSource = data;
            foreach (var item in data)
            {
                var fullName = $"{item.LastName} {item.FirstName}";
                this.CustomerComboBox.ValueMember = item.Id.ToString();
                this.CustomerComboBox.DisplayMember = fullName;
                this.CustomerComboBox.Items.Add(fullName);
            }
        }

        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.DateTimePicker AppointmentDateTimePicker;
        private System.Windows.Forms.GroupBox OrderDetailsGroupBox;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label IssuesWithCarLabel;
        private System.Windows.Forms.Label EmployeeToFixLabel;
        private System.Windows.Forms.TextBox IssuesWithCarTextBox;
        private System.Windows.Forms.Label AppointmentDateLabel;
        private System.Windows.Forms.ComboBox EmployeeToFixComboBox;
        private System.Windows.Forms.TextBox textBox2;
    }
}