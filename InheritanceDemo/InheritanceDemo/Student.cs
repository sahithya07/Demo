using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Student
    {
        protected string StudentName;
        protected int StudentId;
        protected double StudentOneMark;
        protected double StudentTwoMark;
        protected double StudentThreeMark;
        protected double StudentFourMark;
        protected double StudentFiveMark;
        protected double TotalMarks;
        protected double Average;

        public Student()
        {

        }

        public Student(string studentName, int studentId, double studentOneMark, double studentTwoMark, double studentThreeMark, double studentFourMark, double studentFiveMark)
        {
            StudentName = studentName;
            StudentId = studentId;
            StudentOneMark = studentOneMark;
            StudentTwoMark = studentTwoMark;
            StudentThreeMark = studentThreeMark;
            StudentFourMark = studentFourMark;
            StudentFiveMark = studentFiveMark;
        }

        public void CalculateTotal()
        {
            TotalMarks = StudentOneMark + StudentTwoMark + StudentThreeMark + StudentFourMark + StudentFiveMark;
        }

        public virtual double CalculateGrade(double InternalMark)
        {
            Average = InternalMark + TotalMarks / 6.0;
            return Average;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Hi " + StudentName + " Your id is " + StudentId);
            Console.WriteLine("Subject one mark is " + StudentOneMark);
            Console.WriteLine("Subject two mark is " + StudentTwoMark);
            Console.WriteLine("Subject Three mark is " + StudentThreeMark);
            Console.WriteLine("Subject Four mark is " + StudentFourMark);
            Console.WriteLine("Subject Five mark is " + StudentFiveMark);
            Console.WriteLine("Total Mark is " + TotalMarks);

        }
    }
}
