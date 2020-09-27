using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************

   Adrian Bermudez

   Lab #2 - Aug 24, 2020

   I wrote this code myself...

 **************************************************************/
namespace ProjectOne
{
    class Course
    {

        //*******************************Properties****************************************

        private string courseID;
        private string courseName;
        private string descriptionCourse;
        private int creditHours;


        //*******************************Constructors**************************************
        public Course()
        {
            string courseID = "";
            string courseName = "";
            string descriptionCourse = "";
            int creditHours = 0;


        }
        //create contstructor
        public Course(string id, string name, string description, int cHours)
        {

            courseID = id;
            courseName = name;
            descriptionCourse = description;
            creditHours = cHours;

        }

        //*******************************Behaviors*****************************************
        //get and set
        public void setcourseID(string id)
        {
            courseID = id;

        }

        public string getcourseID()
        {

            return courseID;

        }

        public void setcourseName(string name)
        {
            courseName = name;

        }

        public string getcourseName()
        {

            return courseName;

        }
        public void setdescriptionCourse(string description)
        {
            descriptionCourse = description;

        }

        public string getdescriptionCourse()
        {

            return descriptionCourse;

        }
        public void setcreditHours(int cHours)
        {
            creditHours = cHours;

        }

        public int getcreditHours()
        {

            return creditHours;

        }
        //display method to display test information
        public void display()
        {
            Console.WriteLine("Course ID= " + courseID);
            Console.WriteLine("Course Name= " + courseName);
            Console.WriteLine("Course Description= " + descriptionCourse);
            Console.WriteLine("Course Credit Hours= " + creditHours);


        }

    }
}
