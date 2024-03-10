using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_NicolaasDyk
{
    public class User
    {
        private string username;
        private string fName;
        private string lName;
        private string email;
        private string password;

        public User()
        {

        }

        public User(string u, string f, string l, string e, string p)
        {
            username = u;
            fName = f;
            lName = l;
            email = e;
            password = p;
        }

        public string getUsername() { return username; }
        public string getFName() { return fName; }
        public string getLName() { return lName; }
        public string getEmail() { return email; }
        public string getPassword() { return password; }

        public void setUsername(string u) { username = u; }
        public void setFName(string f) {  fName = f; }
        public void setLName(string l) { lName = l; }
        public void setEmail(string e) { email = e; }
        public void setPassword(string p) { password = p; }
    }
}
