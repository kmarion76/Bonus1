using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus1
{
    public class GradeCalculator
    {
        string letterGrade;
        public string Convert(int grade)
        {
            if (grade >= 88)
            {
                letterGrade = "A";
            }
            else if (grade <= 87 && grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade <= 79 && grade >= 67)
            {
                letterGrade = "C";
            }
            else if (grade <= 66 && grade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            return letterGrade;
        }
    }
}
