using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Quanlysinhvien.ManagerStrategy;

namespace Quanlysinhvien
{
    internal class Teacher : Person
    {
        public string Username { get; set; }
        public string Password { get; set; }
        //public List<Student> students;
        public List<Student> students = new List<Student>();
        private Strategy<Student> studentStrategy;
        public Teacher() 
        {
            this.students = new List<Student>();
            this.studentStrategy = new StudentManagementStrategy();
        }

       
        public int QuantityStudent()
        {
            int Count = 0;
            if (students != null)
            {
                Count = students.Count;
            }
            return Count;
        }
        public void AddStudent(Student student)
        {
            this.studentStrategy.Add(this.students, student);
            MediumScore(student);
            SortAcademic(student);
        }

        // Update student
        public void UpdateStudent(int index, Student student)
        {
            this.studentStrategy.Update(this.students, index, student);
            MediumScore(student);
            SortAcademic(student);
        }

        // Delete student
        public void DeleteStudent(int index)
        {
            this.studentStrategy.Delete(this.students, index);
        }

        private void MediumScore( Student student)
        {
            double Medium = (student.Math + student.Chemistry + student.Physics) / 3;
            student.Medium = Math.Round(Medium);
        }
        private void SortAcademic(Student student)
        {
            if(student.Medium >= 8)
            {
                student.Academic = "Good";
            }
            else if (student.Medium >= 6.5) 
            {
                student.Academic = "Quite";
            }
            else if (student.Medium >= 5)
            {
                student.Academic = "Average";
            }
            else { student.Academic = "Bad";  }
        }
        public void SortByID()
        {
            students.Sort(delegate (Student student1, Student student2)
            {
                return student1.ID.CompareTo(student2.ID);
            });
        }
        public void SortByName()
        {
            students.Sort(delegate (Student student1, Student student2)
            {
                return student1.Name.CompareTo(student2.Name);
            });
        }

        public void SortByMedium()
        {
            students.Sort(delegate (Student student1, Student student2)
            {
                return student1.Medium.CompareTo(student2.Medium);
            });
        }
        // Display students
        public void DisplayStudents()
        {
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 8} {4,9} {5, 10} {6, 11} {7, 13}", "ID", "Name", "Gender", "Age", "Math", "Chemistry", "Physisc", "Academic");
            for (int i = 0; i < this.students.Count; i++)
            {
                Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 8} {4,9} {5, 10} {6, 11} {7, 13}", this.students[i].ID, this.students[i].Name, this.students[i].Gender, this.students[i].Age, this.students[i].Math, this.students[i].Physics, this.students[i].Chemistry, this.students[i].Academic );
            }
        }
        public void DisplayMenu()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. Add new student");
            Console.WriteLine("2. Update student");
            Console.WriteLine("3. Delete student");
            Console.WriteLine("4. Sort by medium students");
            Console.WriteLine("5. Sort by ID students");
            Console.WriteLine("6. Sort by name students");
            Console.WriteLine("7. Display students ");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
        }
    }
}
