using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//============================
//Name: Nicolaas Dyk
//Date: 03/10/24
//Desc: User submission app
//============================


namespace HW02_NicolaasDyk
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        int flNameRemainingSpace;
        public Form1()
        {
            InitializeComponent();
            fillDummyData();
            fillTextBox();
            flNameRemainingSpace = txt_fName.MaxLength + 1;
        }

        //Fake users to be filled into the list
        //Max lengths of objects: Username: 14 characters Full Name: 14 characters Email: 27 characters Password: 15 characters
        public void fillDummyData()
        {
            User u1 = new User("bollybod23", "Molly", "Corn", "bollybody23@email.com", "bbeeddss123");
            User u2 = new User("JARtooloo", "Jamie", "Asterisk", "jamieasterisk@email.com", "password1");
            User u3 = new User("Skardle9000", "Jake", "Dunkle", "jakedunkle44@email.com", "password2");
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
        }

        //Fills in the userDispaly textbox with all current data
        public void fillTextBox()
        {
            txt_userDisplay.Text = string.Empty;
            txt_userDisplay.AppendText("===========================================================================================================");
            for (int i = 0; i < users.Count; i++)
            {
                txt_userDisplay.AppendText(Environment.NewLine);
                string username = buffer("Username: " + users[i].getUsername(), 25);
                string name = buffer("Name: " + users[i].getFName() + " " + users[i].getLName(), 22);
                string email = buffer("Email: " + users[i].getEmail(), 35);
                string password = "Password: " + users[i].getPassword();
                txt_userDisplay.AppendText(username + name + email + password + Environment.NewLine);
                txt_userDisplay.AppendText("===========================================================================================================");
            }
        }

        //Adds spaces to the end of a string to allow for even spacing
        public string buffer(string text, int length)
        {
            while (text.Length < length)
            {
                text = text + " ";
            }
            return text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This is the function where a new user will get registered
            //First we create a user based on the text files
            User u = new User(txt_username.Text, txt_fName.Text, txt_lName.Text, txt_email.Text, txt_password.Text);
            if (errorCheck(u))
            {
                Console.WriteLine("Good Data");
                users.Add(u);
                fillTextBox();
                emptyTextBoxes();
            }
            else
            {
                Console.WriteLine("Bad Data");
            }
            
        }

        public bool errorCheck(User u)
        {
            //Check for all possible errors
            //Clear all errors
            lbl_error_emptyFields.Visible = false;
            lbl_error_username.Visible = false;
            lbl_error_invalidPassword.Visible = false;
            lbl_error_unmatchedPassword.Visible = false;
            //First we verify all fields are filled out
            if (!allFieldsFull())
            {
                lbl_error_emptyFields.Visible = true;
                Console.WriteLine("All fields are not full");
                return false;
            }
            //Next, see if the username is unique
            if (!uniqueUsername(u.getUsername()))
            {
                lbl_error_username.Visible = true;
                Console.WriteLine("Username used");
                return false;
            }
            //Now we see if the password meets the requirements
            if (!validPassword(u.getPassword()))
            {
                lbl_error_invalidPassword.Visible = true;
                //Also display the unmatched password error if the passwords do not match
                if (u.getPassword() != txt_verifyPassword.Text)
                    lbl_error_unmatchedPassword.Visible = true;
                Console.WriteLine("Invalid Password");
                return false;
            }
            //Next we see if the password matches the verify password textbox
            if (u.getPassword() != txt_verifyPassword.Text)
            {
                lbl_error_unmatchedPassword.Visible = true;
                Console.WriteLine("Password not copied");
                return false;
            }
            return true;
        }

        //Compares the provided string to all usernames, returning true if its unique and false if it is not
        public bool uniqueUsername(string u)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].getUsername() == u)
                {
                    return false;
                }
            }
            return true;
        }

        //Checks to see if the provides string is longer than 8 characters and contains 1 number
        public bool validPassword(string p)
        {
            if (p.Length < 8)
            {
                return false;
            }
            bool hasNumber = false;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] >= '0' && p[i] <= '9')
                {
                    hasNumber = true;
                }
            }
            return hasNumber;
        }

        //Verifies that all of the textbox fields have content in them
        public bool allFieldsFull()
        {
            if (txt_username.Text == "" ||
                txt_fName.Text == "" ||
                txt_lName.Text == "" ||
                txt_email.Text == "" ||
                txt_password.Text == "" ||
                txt_verifyPassword.Text == "")
                return false;
            return true;
        }

        //Sets all of the textboxes to be empty
        public void emptyTextBoxes()
        {
            txt_username.Text = string.Empty;
            txt_fName.Text = string.Empty;
            txt_lName.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_password.Text = string.Empty;
            txt_verifyPassword.Text = string.Empty;
        }

        //Both of these functions alter the max length of their counterpart textboxes to ensure that a full name cannot be longer than
        //the maximum amount of characters (14)
        private void txt_fName_TextChanged(object sender, EventArgs e)
        {
            //This line sets the maximum length of the lName textbox to be either the maximum length minus the current length of the fName, or the maximum length minus 1 if fName is empty.
            txt_lName.MaxLength = (txt_fName.Text.Length > 0 ? flNameRemainingSpace - txt_fName.Text.Length : flNameRemainingSpace - 1);
        }

        private void txt_lName_TextChanged(object sender, EventArgs e)
        {
            txt_fName.MaxLength = (txt_lName.Text.Length > 0 ? flNameRemainingSpace - txt_lName.Text.Length : flNameRemainingSpace - 1);
        }
    }
}
