using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien
{
    internal class Login2
    {
        private List<Student> _users;

        public Login2()
        {
            // Initialize the list of users
            _users = new List<Student>();
            _users.Add(new Student { Username = "student1", Password = "student1" });
            _users.Add(new Student { Username = "student2", Password = "student2" });
            _users.Add(new Student { Username = "student3", Password = "student3" });
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
