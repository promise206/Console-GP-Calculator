using GPCalculator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPCalculator.UI
{
    public class GetInput
    {
        List<CourseDetails> courses;

        public GetInput()
        {
            courses = new List<CourseDetails>();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to my GP Calculator System!" + Environment.NewLine);
            Console.WriteLine("1. Calculate GP");
            Console.WriteLine("2. Cancel");

            Console.Write("Enter your menu Option: ");

            bool tryParse = int.TryParse(Console.ReadLine(), out int menuOption);

            if (tryParse)
            {
                switch (menuOption)
                {
                    case 1:
                        GetCourseDetails();
                        break;
                    case 2:
                        Exit();
                        break;
                    default:
                        ErrorMessage("Incorrect Option,");
                        DisplayMenu();
                        break;
                }
            }
            else
            {
                ErrorMessage("Incorrect menu choice.");
                DisplayMenu();
            }
        }

        //Gets course Details from User
        public void GetCourseDetails()
        {

            StartOption("---------Add Course Details------------");
            try
            {
                Console.WriteLine("Enter Number of Courses");
                int numberOfCourses = Convert.ToInt32(Console.ReadLine());

                int number = 1;
                while(numberOfCourses > 0) { 
                    Console.Write($"Enter Course Name {number}: ");
                    string courseName = Console.ReadLine();

                    Console.Write($"Enter Course Unit {number}: ");
                    int courseUnit = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"Enter Score {number}: ");
                    double score = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("*************************************");
                    //Checks if the User entered CourseName
                    if (!string.IsNullOrEmpty(courseName))
                    {
                        // Validate Course Unit and Score.
                        if (courseUnit > 0 && courseUnit<=25 && score >= 0 && score<=100)
                        {
                            CourseDetails course = new CourseDetails(courseName, courseUnit, score);
                            courses.Add(course);
                        }else
                        {
                            ErrorMessage("Incorrect Course Unit or Score");
                            GetCourseDetails();
                        }
                    }else
                    {
                        ErrorMessage("You didn't Enter Course Name!");
                        GetCourseDetails();
                    }
                    number++;
                    numberOfCourses--;
                }

                //Forwards course Details to CalculateGP function.
                CalculateGP.Calculate(courses);
                
            }
            catch (Exception)
            {
                ErrorMessage("Something Went Wrong.");
                GetCourseDetails();
                
            }

        }

        //To Exit the system
        public static void Exit()
        {
            Console.WriteLine("Click <Enter> to Exit!");

        }
        //Displays Start Message for Selected Option
        public static void StartOption(string message)
        {
            Console.Clear();
            Console.WriteLine(message + Environment.NewLine);
        }

        //Displays Error Message.
        public static void ErrorMessage(string message)
        {
            Console.Write(message+ ", Press <Enter> to Try Again");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
