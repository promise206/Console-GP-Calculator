using GPCalculator.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPCalculator.Core
{
    public static class CalculateGP
    {
        public static void Calculate(List<CourseDetails> courses)
        {
            int totalUnitRegistered = 0;
            int totalCourseUnitPassed = 0;
            int totalCourseUnit = 0;
            int totalWeightPoint = 0;

            PrintTable.FormatTable();

            for(int i = 0; i < courses.Count; i++)
            {

                string courseName = courses[i].Name;
                int courseUnit = courses[i].CourseUnit;
                double Score = courses[i].Score;
                string grade = GradeScore.Grade(Score);
                int gradeUnit = GradeScore.GradeUnit(grade);
                string remark = GradeScore.Remark(grade);
                //Calculate Weight Point
                int weightPoint = gradeUnit * courseUnit;
                //send detail to Print Table
                PrintTable.DisplayTableItems(courseName, courseUnit, grade, gradeUnit, weightPoint, remark);

                if (gradeUnit == 0)
                {
                    totalCourseUnitPassed += 0;
                }
                else
                {
                    totalCourseUnitPassed += courseUnit;
                }

                totalUnitRegistered += gradeUnit;
                totalWeightPoint += weightPoint;
                totalCourseUnit += courseUnit;
            }
            //Calculates GPA
            double GPA =Math.Round((double) totalWeightPoint / totalCourseUnit,2);
            PrintTable.DisplayGP(totalUnitRegistered, totalCourseUnitPassed, totalWeightPoint, GPA);

        }

    }
}
