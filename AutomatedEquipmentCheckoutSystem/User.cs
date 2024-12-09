using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedEquipmentCheckoutSystem
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool Login(string username, string password)
        {
            return Username == username && Password == password;
        }

        public void Logout()
        {
            Console.WriteLine($"{Username} has logged out.");
        }
    }
}