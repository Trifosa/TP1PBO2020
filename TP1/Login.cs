using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Login
    {
        public string username { get; set; }    // Untuk menyimpan username

        public string pass { get; set; }        // Untuk menyimpan password

        public Login(string username, string pass)  // Menyimpan username dan password ke dalam attribut di class
        {
            this.username = username;
            this.pass = pass;
        }

        public Login() 
        { 
        }
    }
}
