using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Quanlysinhvien.ManagerStrategy;

namespace Quanlysinhvien
{
    internal class Manager
    {
        public string Username { get; set; }
        public string Password { get; set; }
        // Singleton instance
        private static Manager instance = null;

        // List of students
        public List<Student> students;
        public List<Teacher> teachers;
        // Private constructor to prevent instantiation
        private Strategy<Student> studentStrategy;
        private Strategy<Teacher> teacherStrategy;
        private Manager()
        {
            // Initialize list of students
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
            this.studentStrategy = new StudentManagementStrategy();
            this.teacherStrategy = new TeacherManagementStrategy();
        }

        // Get singleton instance
        public static Manager GetInstance()
        {
            if (instance == null)
            {
                instance = new Manager();
            }
            return instance;
        }

        // Add new student
        public void AddStudent(Student student)
        {
            this.studentStrategy.Add(this.students, student);
        }

        public void UpdateStudent(int index, Student student)
        {
            this.studentStrategy.Update(this.students, index, student);
        }

        public void DeleteStudent(int index)
        {
            this.studentStrategy.Delete(this.students, index);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teacherStrategy.Add(this.teachers, teacher);
        }

        public void UpdateTeacher(int index, Teacher teacher)
        {
            this.teacherStrategy.Update(this.teachers, index, teacher);
        }

        public void DeleteTeacher(int index)
        {
            this.teacherStrategy.Delete(this.teachers, index);
        }


        // Display students
        public void Display()
        {
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 8} {4,9} {5, 10} {6, 11} {7, 13}", "ID", "Name", "Gender", "Age", "Math", "Chemistry", "Physisc", "Academic");
            for (int i = 0; i < this.students.Count; i++)
            {
                Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 8} {4,9} {5, 10} {6, 11} {7, 13}", this.students[i].ID, this.students[i].Name, this.students[i].Gender, this.students[i].Age, this.students[i].Math, this.students[i].Physics, this.students[i].Chemistry, this.students[i].Academic);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 8}", "ID", "Name", "Gender", "Age");
            for (int k = 0; k < this.teachers.Count; k++)
            {
                Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 8}", this.teachers[k].ID, this.teachers[k].Name, this.teachers[k].Gender, this.teachers[k].Age);
            }
        }


        // Display menu
        public void DisplayMenu()
        {
            Console.WriteLine("1. Add new student");
            Console.WriteLine("2. Update student");
            Console.WriteLine("3. Delete student");
            Console.WriteLine("4. Add new teacher");
            Console.WriteLine("5. Update teacher");
            Console.WriteLine("6. Delete teacher");
            Console.WriteLine("7. Display students");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
        }
    }
}
