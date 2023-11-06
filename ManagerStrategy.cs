using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien
{
    internal class ManagerStrategy
    {
        public class StudentManagementStrategy : Strategy<Student>
        {
            public void Add(List<Student> list, Student item)
            {

                if (list.Count < 3)
                {
                    list.Add(item);
                    Console.WriteLine("Student added successfully.");
                }
                else
                {
                    Console.WriteLine("The maximum number of students (30) has been reached.");
                }
            }

            public void Update(List<Student> list, int index, Student item)
            {
                list[index] = item;
            }

            public void Delete(List<Student> list, int index)
            {
                list.RemoveAt(index);
            }
        }

        public class TeacherManagementStrategy : Strategy<Teacher>
        {
            public void Add(List<Teacher> list, Teacher item)
            {
                if (list.Count < 3)
                {
                    list.Add(item);
                    Console.WriteLine("Teacher added successfully.");
                }
                else
                {
                    Console.WriteLine("The maximum number of teachers (3) has been reached.");
                }
            }

            public void Update(List<Teacher> list, int index, Teacher item)
            {
                list[index] = item;
            }

            public void Delete(List<Teacher> list, int index)
            {
                list.RemoveAt(index);
            }
        }

    }
}
