using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }

        private List<Student> students = new List<Student>();
            public Course(string id, string name)
        {
            CourseID = id;
            CourseName = name;
        }
        public void AddStudent(Student s)
        {
            students.Add(s);
        }
        public void ShowStudents()
        {
            foreach (var s in students)
            {
                s.Display();
            }
        }
        public void ShoweMaxMin()
        {
            var max = students.Max(s => s.Score);
            var min = students.Min(s => s.Score);

            Console.WriteLine("คะแนนสูงสุด: " + max);
            Console.WriteLine("คะแนนต่ำสุด: " + min);
        }
        public void Average()
        {
            var avg = students.Average(s => s.Score);
            Console.WriteLine("คะแนนเฉลี่ย: " + avg);
        }

        internal void ShowAverage()
        {
            throw new NotImplementedException();
        }
    }
}
