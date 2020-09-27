using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************

   Adrian Bermudez

   Lab #4 - Sep 7, 2020

   I wrote this code myself...

 **************************************************************/
namespace ProjectOne
{
    class Section
    {
        public int count = 0;
        public Section[] sList = new Section[10];
        public void addSection(Section s1)
        {

            sList[count] = s1;
            count++;

        }


        public void displaySection()
        {

            foreach (Section s in sList)
            {
                s.displaySection();

            }
        }


        //*******************************Properties****************************************
        private string CRN;
        private string CourseID;
        private string TimeDays;
        private string RoomNo;
        private string InstructorID;

        //*******************************Constructors**************************************
        public Section()
        {
            string CRN = "";
            string CourseID = "";
            string TimeDays = "";
            string RoomNo = "";
            string InstructorID = "";


        }
        //create contstructor
        public Section(string crn, string courseid, string timedays, string roomno, string instructor)
        {

            CRN = crn;
            CourseID = courseid;
            TimeDays = timedays;
            RoomNo = roomno;
            InstructorID = instructor;

        }

        //*******************************Behaviors*****************************************

        //get and set
        public void setCRN(string crn)
        {
            CRN = crn;

        }

        public string getCRN()
        {

            return CRN;

        }

        public void setCourseID(string courseid)
        {
            CourseID = courseid;

        }

        public string getCourseID()
        {

            return CourseID;

        }

        public void setTimeDays(string timedays)
        {
            TimeDays = timedays;

        }

        public string getTimedays()
        {

            return TimeDays;

        }

        public void setRoomNo(string roomno)
        {
            RoomNo = roomno;

        }

        public string getRoomNo()
        {

            return RoomNo;

        }

        public void setInstructorID(string instructor)
        {
            InstructorID = instructor;

        }

        public string getInstructorID()
        {

            return InstructorID;

        }
        //display method to display test information
        public void display()
        {

            Console.WriteLine("CRN = " + CRN);
            Console.WriteLine("Course ID = " + CourseID);
            Console.WriteLine("Time and Day = " + TimeDays); 
            Console.WriteLine("Room Number = " + RoomNo); 
            Console.WriteLine("Instructor ID = " + InstructorID);



        }

    }
}
