using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Quanlysinhvien
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                // Initialize the login system
                Login loginSystem = new Login();
                Login2 login2 = new Login2();
                Login3 login3 = new Login3();

                {  // Ask the user to log in
                    while (true)
                    {
                        Console.WriteLine("Welcome to the system!");
                        Console.Write("Username: ");
                        string username = Console.ReadLine();
                        Console.Write("Password: ");
                        string password = Console.ReadLine();

                        // Check if the user's login credentials are valid
                        if (loginSystem.ValidateLogin(username, password))
                        {
                            Console.WriteLine("Login successful!");
                            Manager studentManager = Manager.GetInstance();
                            List<Student> students = new List<Student>();
                            
                            Student student1 = new Student()
                            {
                                ID = "1",
                                Name = "Vu Van A",
                                Gender = "Male",
                                Age = 20,
                                Math = 8,
                                Physics = 7,
                                Chemistry = 9,
                                Academic = "Good",
                            };
                            Student student2 = new Student()
                            {
                                ID = "2",
                                Name = "Emily",
                                Gender = "Female",
                                Age = 19,
                                Math = 9,
                                Physics = 8,
                                Chemistry = 9,
                                Academic = "Good",

                            };
                            studentManager.AddStudent(student1);
                            studentManager.AddStudent(student2);
                            List<Teacher> teachers = new List<Teacher>();
                            Teacher teachers1 = new Teacher()
                            {
                                 ID = "1",
                                 Name = "Vu Van A",
                                 Gender = "Male",
                                 Age = 20
                            };
                            Teacher teachers2 = new Teacher()
                            {
                                 ID = "2",
                                 Name = "Vu Van A",
                                 Gender = "Male",
                                 Age = 20
                            };
                            studentManager.AddTeacher(teachers1);
                            studentManager.AddTeacher(teachers2);

                            while (true)
                            {
                                // Display menu
                                studentManager.DisplayMenu();

                                // Read user choice
                                int choice = int.Parse(Console.ReadLine());

                                switch (choice)
                                {
                                    case 1:
                                        // Add new student
                                        Console.Write("Enter name: ");
                                        string name = Console.ReadLine();
                                        Console.Write("Enter age: ");
                                        int age = int.Parse(Console.ReadLine());
                                        Console.Write("Enter gender: ");
                                        string gender = Console.ReadLine();
                                        Console.Write("Enter ID: ");
                                        string id = Console.ReadLine();
                                        Student student = new Student { Name = name, Age = age, Gender = gender, ID = id };
                                        studentManager.AddStudent(student);
                                        Console.WriteLine("Student added successfully");
                                        break;

                                    case 2:
                                        // Update student
                                        Console.Write("Enter student ID: ");
                                        int index = int.Parse(Console.ReadLine()) - 1;
                                        if (index >= 0 && index < studentManager.students.Count)
                                        {
                                            Console.Write("Enter name: ");
                                            name = Console.ReadLine();
                                            Console.Write("Enter age: ");
                                            age = int.Parse(Console.ReadLine());
                                            Console.Write("Enter gender: ");
                                            gender = Console.ReadLine();
                                            Console.Write("Enter ID: ");
                                            id = Console.ReadLine();
                                            student = new Student { Name = name, Age = age, Gender = gender, ID = id };
                                            studentManager.UpdateStudent(index, student);
                                            Console.WriteLine("Student updated successfully");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid student index");
                                        }
                                        break;

                                    case 3:
                                        // Delete student
                                        Console.Write("Enter student index: ");
                                        index = int.Parse(Console.ReadLine()) - 1;
                                        if (index >= 0 && index < studentManager.students.Count)
                                        {
                                            studentManager.DeleteStudent(index);
                                            Console.WriteLine("Student deleted successfully");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid student index");
                                        }
                                        break;

                                    case 4:
                                        // Add new teacher
                                        Console.Write("Enter name: ");
                                        string namet = Console.ReadLine();
                                        Console.Write("Enter age: ");
                                        int aget = int.Parse(Console.ReadLine());
                                        Console.Write("Enter gender: ");
                                        string gendert = Console.ReadLine();
                                        Console.Write("Enter ID: ");
                                        string idt = Console.ReadLine();
                                        Teacher teacher = new Teacher { Name = namet, Age = aget, Gender = gendert, ID = idt };
                                        studentManager.AddTeacher(teacher);
                                        Console.WriteLine("Teacher added successfully");
                                        break;

                                    case 5:
                                        Console.Write("Enter student ID: ");
                                        int indexT = int.Parse(Console.ReadLine()) - 1;
                                        if (indexT >= 0 && indexT < studentManager.students.Count)
                                        {
                                            Console.Write("Enter name: ");
                                            namet = Console.ReadLine();
                                            Console.Write("Enter age: ");
                                            aget = int.Parse(Console.ReadLine());
                                            Console.Write("Enter gender: ");
                                            gendert = Console.ReadLine();
                                            Console.Write("Enter ID: ");
                                            idt = Console.ReadLine();
                                            teacher = new Teacher { Name = namet, Age = aget, Gender = gendert, ID = idt };
                                            studentManager.UpdateTeacher(indexT, teacher);
                                            Console.WriteLine("Teacher updated successfully");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid teacher index");
                                        }
                                        break;
                                    case 6:
                                        Console.Write("Enter teacher index: ");
                                        indexT = int.Parse(Console.ReadLine()) - 1;
                                        if (indexT >= 0 && indexT < studentManager.teachers.Count)
                                        {
                                            studentManager.DeleteTeacher(indexT);
                                            Console.WriteLine("Teacher deleted successfully");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid teacher index");
                                        }
                                        break;
                                    case 7:
                                        studentManager.Display();
                                        break;

                                    case 8:
                                        // Exit program
                                        Console.WriteLine("Exiting program...");
                                        return;

                                    default:
                                        Console.WriteLine("Invalid choice");
                                        break;
                                }

                                Console.WriteLine();
                            }

                        }
                        else if (login2.ValidateLogin(username, password))
                        {

                            Console.WriteLine("Login successful!");
                            List<Student> students = new List<Student>();
                            Teacher teachers = new Teacher();
                            Student student1 = new Student()
                            {
                                ID = "1",
                                Name = "Vu Van A",
                                Gender = "Male",
                                Age = 20,
                                Math = 8,
                                Physics = 7,
                                Chemistry = 9,
                                Academic = "Good",
                            };
                            Student student2 = new Student()
                            {
                                ID = "2",
                                Name = "Emily",
                                Gender = "Female",
                                Age = 19,
                                Math = 9,
                                Physics = 8,
                                Chemistry = 9,
                                Academic = "Good",

                            };
                            teachers.AddStudent(student1);
                            teachers.AddStudent(student2);
                            Student student = new Student();
                           /* student.DisplayStudents(students)*/

                            Console.WriteLine();
                            teachers.DisplayStudents();
                            bool exit = false;
                            while (!exit)
                            {
                                int choice;
                                if (int.TryParse(Console.ReadLine(), out choice))
                                {
                                    switch (choice)
                                    {
                                        case 1:
                                            //student.DisplayStudents(students);
                                            break;

                                        default:
                                            Console.WriteLine("Invalid choice. Please try again.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid choice. Please try again.");
                                }

                                Console.WriteLine();
                                //student.DisplayMenu();
                            }

                            Console.ReadLine();
                        }
                        else if (login3.ValidateLogin(username, password))
                        {
                            Console.WriteLine("Login successful!");
                            Teacher teachers = new Teacher();
                            Student student1 = new Student()
                            {
                                ID = "1",
                                Name = "Vu Van A",
                                Gender = "Male",
                                Age = 20,
                                Math = 8,
                                Physics = 7,
                                Chemistry = 9,
                                Academic = "Good",
                            };
                            Student student2 = new Student()
                            {
                                ID = "2",
                                Name = "Emily",
                                Gender = "Female",
                                Age = 19,
                                Math = 9,
                                Physics = 8,
                                Chemistry = 9,
                                Academic = "Good",

                            };
                            Student student3 = new Student()
                            {
                                ID = "3",
                                Name = "Mike",
                                Gender = "Male",
                                Age = 19,
                                Math = 9,
                                Physics = 8,
                                Chemistry = 9,
                                Academic = "Good",

                            };
                            Student student4 = new Student()
                            {
                                ID = "4",
                                Name = "Jond",
                                Gender = "Male",
                                Age = 19,
                                Math = 9,
                                Physics = 8,
                                Chemistry = 9,
                                Academic = "Good",

                            };

                            teachers.AddStudent(student1);
                            teachers.AddStudent(student2);
                            teachers.AddStudent(student3);
                            teachers.AddStudent(student4);

                            while (true)
                            {
                                // Display menu
                                teachers.DisplayMenu();

                                // Read user choice
                                int choice = int.Parse(Console.ReadLine());

                                switch (choice)
                                {
                                    case 1:
                                        // Add new student
                                        Console.Write("Enter name: ");
                                        string name = Console.ReadLine();
                                        Console.Write("Enter age: ");
                                        int age = int.Parse(Console.ReadLine());
                                        Console.Write("Enter gender: ");
                                        string gender = Console.ReadLine();
                                        Console.Write("Enter ID: ");
                                        string id = Console.ReadLine();
                                        Console.Write("Math score: ");
                                        double math = Convert.ToDouble(Console.ReadLine());
                                        Console.Write("Physics score: ");
                                        double physics = Convert.ToDouble(Console.ReadLine());
                                        Console.Write("Chemistry score: ");
                                        double chemistry = Convert.ToDouble(Console.ReadLine());
                                        Student student = new Student { Name = name, Age = age, Gender = gender, ID = id, Math = math, Physics = physics, Chemistry = chemistry };
                                        teachers.AddStudent(student);
                                        
                                        break;

                                    case 2:
                                        // Update student
                                        Console.Write("Enter student ID: ");
                                        int index = int.Parse(Console.ReadLine()) - 1;
                                        if (index >= 0 && index < teachers.students.Count)
                                        {
                                            Console.Write("Enter name: ");
                                            name = Console.ReadLine();
                                            Console.Write("Enter age: ");
                                            age = int.Parse(Console.ReadLine());
                                            Console.Write("Enter gender: ");
                                            gender = Console.ReadLine();
                                            Console.Write("Enter ID: ");
                                            id = Console.ReadLine();
                                            Console.Write("Enter Math score: ");
                                            math = Convert.ToDouble(Console.ReadLine());
                                            Console.Write("Enter Physics score: ");
                                            physics = Convert.ToDouble(Console.ReadLine());
                                            Console.Write("Enter Chemistry score: ");
                                            chemistry = Convert.ToDouble(Console.ReadLine());
                                            student = new Student { Name = name, Age = age, Gender = gender, ID = id, Math = math, Chemistry = chemistry, Physics = physics };
                                            teachers.UpdateStudent(index, student);
                                            Console.WriteLine("Student updated successfully");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid student index");
                                        }
                                        break;

                                    case 3:
                                        // Delete student
                                        Console.Write("Enter student ID: ");
                                        index = int.Parse(Console.ReadLine()) - 1;
                                        if (index >= 0 && index < teachers.students.Count)
                                        {
                                            teachers.DeleteStudent(index);
                                            Console.WriteLine("Student deleted successfully");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid student ID");
                                        }
                                        break;

                                    case 4:
                                        if (teachers.QuantityStudent() > 0)
                                        {
                                            Console.WriteLine("\nSort by ID student.");
                                            teachers.SortByID();
                                            teachers.DisplayStudents();
                                        }
                                        break;
                                    case 5:
                                        if (teachers.QuantityStudent() > 0)
                                        {
                                            Console.WriteLine("\nSort by Name student.");
                                            teachers.SortByName();
                                            teachers.DisplayStudents();
                                        }
                                        break;
                                    case 6:
                                        if (teachers.QuantityStudent() > 0)
                                        {
                                            Console.WriteLine("\nSort by Medium student.");
                                            teachers.SortByMedium();
                                            teachers.DisplayStudents();
                                        }
                                        break;

                                    case 7:
                                        // Display students
                                        teachers.DisplayStudents();
                                        break;

                                    case 8:
                                        // Exit program
                                        Console.WriteLine("Exiting program...");
                                        return;

                                    default:
                                        Console.WriteLine("Invalid choice");
                                        break;
                                }

                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid login credentials.");
                        }

                        Console.ReadLine();

                    }
                        //Console.WriteLine();
                }
            }
        }
    }
}
