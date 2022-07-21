using GPCalculator.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPCalculator.Core
{
    public class GradeScore
    {
        public static string Grade(double score)
        {
            string grade = "";

            if (score >= 70 && score <= 100)
            {
                grade = "A";
            } else if (score >= 60 && score < 70)
            {
                grade = "B";
            } else if (score >= 50 && score < 60)
            {
                grade = "C";
            } else if (score >= 45 && score < 50)
            {
                grade = "D";
            } else if (score >= 40 && score < 45)
            {
                grade = "E";
            }
            else if (score >= 0 && score < 40)
            {
                grade = "F";
            }
            else
            { 
            }
            return grade;
        }

        public static int GradeUnit(string grade)
        {
            int gradeUnit = 0;
            switch (grade)
            {
                case "A":
                    gradeUnit = 5;
                    break;
                case "B":
                    gradeUnit = 4;
                    break;
                case "C":
                    gradeUnit = 3;
                    break;
                case "D":
                    gradeUnit = 2;
                    break;
                case "E":
                    gradeUnit = 1;
                    break;
                case "F":
                    gradeUnit = 0;
                    break;
            }

            return gradeUnit;
        }

        public static string Remark(string grade)
        {
            string remark = "";
            switch (grade)
            {
                case "A":
                    remark = "Excellent";
                    break;
                case "B":
                    remark = "Very Good";
                    break;
                case "C":
                    remark = "Good";
                    break;
                case "D":
                    remark = "Fair";
                    break;
                case "E":
                    remark = "Pass";
                    break;
                case "F":
                    remark = "Fail";
                    break;
            }

            return remark;
        
        }
    }
}
