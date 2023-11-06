using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien
{
    internal class Login3
    {
        private List<Teacher> _users;

        public Login3()
        {
            // Initialize the list of users
            _users = new List<Teacher>();
            _users.Add(new Teacher { Username = "teacher1", Password = "teacher1" });
            _users.Add(new Teacher { Username = "teacher2", Password = "teacher2" });
            _users.Add(new Teacher { Username = "teacher3", Password = "teacher3" });
        }

        public bool ValidateLogin(string username, string password)
        {
            // Check if the user exists and their password is correct
            foreach (Teacher user in _users)
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
