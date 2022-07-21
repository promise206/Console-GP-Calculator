using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPCalculator.UI
{
    public class PrintTable
    {

        public static void FormatTable()
        {
            Console.WriteLine("|-----------------------------------------------------------------------------------------------------------|");
            Console.WriteLine($"| {"COURSE & CODE",15} | {"COURSE UNIT",15} | {"GRADE",15} | {"GRADE UNIT",15} | {"WEIGHT Pt.",15} | {"REMARK",15} |");
            Console.WriteLine("|-----------------------------------------------------------------------------------------------------------|");
        }
        public static void DisplayTableItems(string courseCode, int courseUnit,string grade, int gradeUnit, int weightPoint, string remark)
        {
            
            Console.WriteLine("| {0,15} | {1,15} | {2,15} | {3,15} | {4,15} | {5,15} |", courseCode, courseUnit, grade, gradeUnit, weightPoint, remark);
            Console.WriteLine("|-----------------------------------------------------------------------------------------------------------|");

        }

        public static void DisplayGP(int totalCourseUnitReg, int totalCourseUnitPassed,int totalWeightPoint, double GPA)
        {
            Console.WriteLine("Total Course Unit Registered is " + totalCourseUnitReg);
            Console.WriteLine("Total Course Unit Passed is "+totalCourseUnitPassed);
            Console.WriteLine("Total Weight Point is "+totalWeightPoint);

            Console.WriteLine("Your GPA is " + GPA);

        }

    }
}
