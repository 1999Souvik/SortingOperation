using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOperation
{
    internal class Program
    {
           static void Main(string[] args)
           {
                runApp();
           }

            static void runApp()
            {
                Student[] students = new Student[5];
                students[0] = new Student { Name = "Kunal", Age = 22 };
                students[1] = new Student { Name = "Mohan", Age = 45 };
                students[2] = new Student { Name = "Amrita", Age = 29 };
                students[3] = new Student { Name = "Salini", Age = 12 };
                students[4] = new Student { Name = "Sruti", Age = 36 };

            //BubbleSort.Sort(students);
            //SelectionSort.Sort(students);
            //InsertionSort.Sort(students);
            //MergeSort.Sort(students);
            //ShellSort.Sort(students);
            //QuickSort.Sort(students, 0, students.Length - 1);


            Console.WriteLine("Sorted Students Name and Age:");
                PrintStudents(students);

                Console.ReadLine();
            }

            static void PrintStudents(Student[] students)
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
                }
            }

    }
}

