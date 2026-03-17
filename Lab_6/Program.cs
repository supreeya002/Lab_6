using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Program
    {
        static void Main()
        {
            Course c = new Course ("cs101", "programming");
            while (true)
            {
                Console.WriteLine("1 Add Student");
                Console.WriteLine("2 show Students");
                Console.WriteLine("3 show max/min Score");
                Console.WriteLine("4 show Average");
                Console.WriteLine("5 Exit");

                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)

                {
                    Console.WriteLine("Name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Student ID");
                    string ID = Console.ReadLine();

                    Console.WriteLine("Score: ");
                    double score = double.Parse(Console.ReadLine());

                    Student s = new Student(name, ID, score);
                    c.AddStudent(s);
                }
                else if (choice == 2)
                    c.ShowStudents();

                else if (choice == 3)
                    c.ShoweMaxMin();

                else if (choice == 4)
                    c.ShowAverage();

                else if (choice == 5)
                    break;
            }
        }
    }
}
