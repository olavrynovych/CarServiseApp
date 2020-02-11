namespace CarServiceDesktop
{
    partial class Form1
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
            this.CreateUser_button = new System.Windows.Forms.Button();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.Surnname_textbox = new System.Windows.Forms.TextBox();
            this.Phone_textbox = new System.Windows.Forms.TextBox();
            this.Details_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Details_textbox);
            this.Controls.Add(this.Phone_textbox);
            this.Controls.Add(this.Surnname_textbox);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.CreateUser_button);
            this.Name = "Form1";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

