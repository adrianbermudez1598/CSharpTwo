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
    class Instructor : Person
    {
        //*******************************Properties****************************************
        private string InstructorID;

        private string InstructorFirstName;

        private string InstructorLastName;

        private string EmailAddress;

        private string PhysicalAddress;

        private string OfficeNumber;


        //sets fields to blank to test
        public Instructor()
        {

            string InstructorID = "";
            string InstructorFirstName = "";
            string InstructorLastName = "";
            string EmailAddress = "";
            string PhysicalAddress = "";
            string OfficeNumber = "";

        }




        //*******************************Constructors**************************************
        //create contstructor
        public Instructor(string InstructorID1, string InstructorFirstName1, string InstructorLastName1, string EmailAddress1, string PhysicalAddress1, string OfficeNumber1)
        {
            InstructorID = InstructorID1;
            InstructorFirstName = InstructorFirstName1;
            InstructorLastName = InstructorLastName1;
            EmailAddress = EmailAddress1;
            PhysicalAddress = PhysicalAddress1;
            OfficeNumber = OfficeNumber1;
        }

        //*******************************Behaviors*****************************************
        public string InstructorID1 { get => InstructorID; set => InstructorID = value; }
        public string InstructorFirstName1 { get => InstructorFirstName; set => InstructorFirstName = value; }
        public string InstructorLastName1 { get => InstructorLastName; set => InstructorLastName = value; }
        public string EmailAddress1 { get => EmailAddress; set => EmailAddress = value; }
        public string PhysicalAddress1 { get => PhysicalAddress; set => PhysicalAddress = value; }
        public string OfficeNumber1 { get => OfficeNumber; set => OfficeNumber = value; }
        //display method to display the information inputted

        public void Display()
        {
            Console.WriteLine("Instructor ID: " + InstructorID);
            Console.WriteLine("Instructor First Name: " + InstructorFirstName );
            Console.WriteLine("Instructor Last Name: " + InstructorLastName );
            Console.WriteLine("Email Address: " + EmailAddress);
            Console.WriteLine("Physical Address: " + PhysicalAddress);
            Console.WriteLine("Office Number: " + OfficeNumber );










        }
    }
}
