namespace HW02_NicolaasDyk
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_userDisplay = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_fName = new System.Windows.Forms.TextBox();
            this.txt_lName = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_verifyPassword = new System.Windows.Forms.TextBox();
            this.lbl_error_username = new System.Windows.Forms.Label();
            this.lbl_error_invalidPassword = new System.Windows.Forms.Label();
            this.lbl_error_unmatchedPassword = new System.Windows.Forms.Label();
            this.lbl_error_emptyFields = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_userDisplay
            // 
            this.txt_userDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userDisplay.Location = new System.Drawing.Point(12, 321);
            this.txt_userDisplay.Multiline = true;
            this.txt_userDisplay.Name = "txt_userDisplay";
            this.txt_userDisplay.ReadOnly = true;
            this.txt_userDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_userDisplay.Size = new System.Drawing.Size(776, 117);
            this.txt_userDisplay.TabIndex = 1;
            this.txt_userDisplay.Text = resources.GetString("txt_userDisplay.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txt_username.Location = new System.Drawing.Point(12, 53);
            this.txt_username.MaxLength = 14;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(112, 20);
            this.txt_username.TabIndex = 3;
            // 
            // txt_fName
            // 
            this.txt_fName.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txt_fName.Location = new System.Drawing.Point(344, 53);
            this.txt_fName.MaxLength = 13;
            this.txt_fName.Name = "txt_fName";
            this.txt_fName.Size = new System.Drawing.Size(112, 20);
            this.txt_fName.TabIndex = 4;
            this.txt_fName.TextChanged += new System.EventHandler(this.txt_fName_TextChanged);
            // 
            // txt_lName
            // 
            this.txt_lName.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txt_lName.Location = new System.Drawing.Point(676, 53);
            this.txt_lName.MaxLength = 13;
            this.txt_lName.Name = "txt_lName";
            this.txt_lName.Size = new System.Drawing.Size(112, 20);
            this.txt_lName.TabIndex = 5;
            this.txt_lName.TextChanged += new System.EventHandler(this.txt_lName_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txt_email.Location = new System.Drawing.Point(112, 144);
            this.txt_email.MaxLength = 27;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(200, 20);
            this.txt_email.TabIndex = 6;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txt_password.Location = new System.Drawing.Point(576, 126);
            this.txt_password.MaxLength = 15;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(112, 20);
            this.txt_password.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(674, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(178, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(460, 65);
            this.button1.TabIndex = 13;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(547, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Verify Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_verifyPassword
            // 
            this.txt_verifyPassword.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txt_verifyPassword.Location = new System.Drawing.Point(576, 200);
            this.txt_verifyPassword.MaxLength = 15;
            this.txt_verifyPassword.Name = "txt_verifyPassword";
            this.txt_verifyPassword.Size = new System.Drawing.Size(112, 20);
            this.txt_verifyPassword.TabIndex = 14;
            // 
            // lbl_error_username
            // 
            this.lbl_error_username.AutoSize = true;
            this.lbl_error_username.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_username.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_username.Location = new System.Drawing.Point(25, 76);
            this.lbl_error_username.Name = "lbl_error_username";
            this.lbl_error_username.Size = new System.Drawing.Size(88, 16);
            this.lbl_error_username.TabIndex = 16;
            this.lbl_error_username.Text = "Username Taken";
            this.lbl_error_username.Visible = false;
            // 
            // lbl_error_invalidPassword
            // 
            this.lbl_error_invalidPassword.AutoSize = true;
            this.lbl_error_invalidPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_error_invalidPassword.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_invalidPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_invalidPassword.Location = new System.Drawing.Point(464, 150);
            this.lbl_error_invalidPassword.Name = "lbl_error_invalidPassword";
            this.lbl_error_invalidPassword.Size = new System.Drawing.Size(336, 16);
            this.lbl_error_invalidPassword.TabIndex = 17;
            this.lbl_error_invalidPassword.Text = "Password Must Be Greater Than 8 Characters And Have 1 Number";
            this.lbl_error_invalidPassword.Visible = false;
            // 
            // lbl_error_unmatchedPassword
            // 
            this.lbl_error_unmatchedPassword.AutoSize = true;
            this.lbl_error_unmatchedPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_error_unmatchedPassword.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_unmatchedPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_unmatchedPassword.Location = new System.Drawing.Point(564, 223);
            this.lbl_error_unmatchedPassword.Name = "lbl_error_unmatchedPassword";
            this.lbl_error_unmatchedPassword.Size = new System.Drawing.Size(135, 16);
            this.lbl_error_unmatchedPassword.TabIndex = 18;
            this.lbl_error_unmatchedPassword.Text = "Passwords Do Not Match";
            this.lbl_error_unmatchedPassword.Visible = false;
            // 
            // lbl_error_emptyFields
            // 
            this.lbl_error_emptyFields.AutoSize = true;
            this.lbl_error_emptyFields.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_error_emptyFields.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_emptyFields.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_emptyFields.Location = new System.Drawing.Point(341, 231);
            this.lbl_error_emptyFields.Name = "lbl_error_emptyFields";
            this.lbl_error_emptyFields.Size = new System.Drawing.Size(128, 16);
            this.lbl_error_emptyFields.TabIndex = 19;
            this.lbl_error_emptyFields.Text = "All Fields Must Be Filled";
            this.lbl_error_emptyFields.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_error_emptyFields);
            this.Controls.Add(this.lbl_error_unmatchedPassword);
            this.Controls.Add(this.lbl_error_invalidPassword);
            this.Controls.Add(this.lbl_error_username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_verifyPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_lName);
            this.Controls.Add(this.txt_fName);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_userDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_userDisplay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_fName;
        private System.Windows.Forms.TextBox txt_lName;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_verifyPassword;
        private System.Windows.Forms.Label lbl_error_username;
        private System.Windows.Forms.Label lbl_error_invalidPassword;
        private System.Windows.Forms.Label lbl_error_unmatchedPassword;
        private System.Windows.Forms.Label lbl_error_emptyFields;
    }
}

