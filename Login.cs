using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien
{
    internal class Login
    {
        private List<Student> _users;

        public Login()
        {
            // Initialize the list of users
            _users = new List<Student>();
            _users.Add(new Student { Username = "1", Password = "1" });
            _users.Add(new Student { Username = "2", Password = "2" });
            _users.Add(new Student { Username = "3", Password = "3" });
        }

        public bool ValidateLogin(string username, string password)
        {
            // Check if the user exists and their password is correct
            foreach (Student user in _users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
    

