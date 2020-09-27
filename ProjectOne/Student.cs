using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************

Adrian Bermudez

Lab #2 - Sep 6, 2020

I wrote this code myself...

**************************************************************/
namespace ProjectOne
{
    class Student : Person
    {

        //*******************************Properties****************************************
        private string StudentID;
        private string FirstName;
        private string LastName;
        private string EmailAddress;
        private string PhysicalAddress;
        private double GPA;



        //*******************************Constructors**************************************
        //sets fields to blank to test
        public Student()
        {

            string StudentID = "";
            string FirstName = "";
            string LastName = "";
            string EmailAddress = "";
            string PhysicalAddress = "";
            double GPA = 00.0d;

        }

        //create constructor

        public Student(string StudentID1, string FirstName1, string LastName1, string EmailAddress1, string PhysicalAddress1, double GPA1)
        {

            StudentID = StudentID1;
            FirstName = FirstName1;
            LastName = LastName1;
            EmailAddress = EmailAddress1;
            PhysicalAddress = PhysicalAddress1;
            GPA = GPA1;
        }




        //*******************************Behaviors*****************************************
        public string StudentID1 { get => StudentID; set => StudentID = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string EmailAddress1 { get => EmailAddress; set => EmailAddress = value; }
        public string PhysicalAddress1 { get => PhysicalAddress; set => PhysicalAddress = value; }
        public double GPA1 { get => GPA; set => GPA = value; }

        //display method to display the information inputted

        public void Display()
        {

            Console.WriteLine("Student ID: " + StudentID);
            base.Display();
            Console.WriteLine("GPA: " + GPA);




        }

    }
}
