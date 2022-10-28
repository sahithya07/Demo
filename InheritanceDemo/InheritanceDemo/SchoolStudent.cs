using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class SchoolStudent:Student
    {
        private string Grade;
        private char Section;

        public SchoolStudent(string Grade, char Section, string studentName, int studentId, double studentOneMark, double studentTwoMark, double studentThreeMark, double studentFourMark, double studentFiveMark) : base(studentName, studentId, studentOneMark, studentTwoMark, studentThreeMark, studentFourMark, studentFiveMark)
        {
            this.Grade = Grade;
            this.Section = Section;
        }

        public void DisplaySchoolStudantDetails()
        {
            Console.WriteLine("Hi " + StudentName + " You study in grade " + Grade + " in division " + Section);
        }
    }
}
