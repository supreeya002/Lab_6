using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Student : Person
    {
        public string StudentID { get; set; }
        public double Score { get; set; }

        public Student(string name, string id, double score)  : base(name)
        {
            StudentID = id;
            Score = score;
        }
        public string GetGrade()
        {
            if (Score >= 80) return "A";
            else if (Score >= 75) return "B+";
            else if (Score >= 70) return "B";
            else if (Score >= 65) return "D+";
            else if (Score >= 60) return "D";
            else if (Score >= 55) return "C+";
            else if (Score >= 50) return "C";
            else return "F";
        }
        public override void Display()
        {
            Console.WriteLine($"{StudentID} {Name} Score: {Score} Grad:{GetGrade()}");
        }
    }
}
