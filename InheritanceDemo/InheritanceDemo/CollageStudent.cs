using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class CollageStudent:Student
    {
        private string Department;
        private string Semester;
        private bool HasRequiredAttendance;

        public CollageStudent(string Department, string Semester, bool HasRequiredAttendance, string studentName, int studentId, double studentOneMark, double studentTwoMark, double studentThreeMark, double studentFourMark, double studentFiveMark) : base(studentName, studentId, studentOneMark, studentTwoMark, studentThreeMark, studentFourMark, studentFiveMark)
        {
            this.Department = Department;
            this.Semester = Semester;
            this.HasRequiredAttendance = HasRequiredAttendance; 
        }
        public override double CalculateGrade(double InternalMark)
        {
            if (HasRequiredAttendance)
            {
                Average = InternalMark + TotalMarks / 6.0;
            }
            else
            {
                Average=(TotalMarks)/6.0;
            }
            return Average;

        }

        public void DisplayCollageStudentDetails()
        {
            Console.WriteLine("You study in "+Department+" in "+Semester+" Semester ");
            if(HasRequiredAttendance)
            {
                Console.WriteLine("You have required attendance "+" Hence internal mark would be awarded");
            }
            else
            {
                Console.WriteLine("You do not have required attendance "+" hence internal marks would not be awarded");
            }
        }
    }
}
