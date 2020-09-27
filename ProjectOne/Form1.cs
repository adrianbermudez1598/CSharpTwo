using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**************************************************************

Adrian Bermudez

Lab #2 - Aug Sep 7, 2020

I wrote this code myself...

**************************************************************/
namespace ProjectOne
{
    public partial class Form1 : Form
    {//initialize form
        public Form1()
        {
            InitializeComponent();
        }
        //test course button click functionality
        private void TestCourseBtn_Click(object sender, EventArgs e)
        {
            Course c1;
            c1 = new Course("CIST 2341", "C# Programming II", "More C# Coding", 4);
        }
        //test section button click functionality
        private void TestSectionClassBtn_Click(object sender, EventArgs e)
        {
            Section s1;
            s1 = new Section("12345", "CIST 2341", "Tuesdays at 1:25PM", "F145", "Instructor Ron Enz");
        }
        //test Address button click functionality
        private void TestAddressClassBtn_Click(object sender, EventArgs e)
        {
            Address a1;
            a1 = new Address("940 Cauthen Court NE", "Marietta", "GA", "30188");
        }

        private void TestPersonClassButton_Click(object sender, EventArgs e)
        {
            Person p1;
            p1 = new Person("Adrian", "Bermudez", "abermud1@studennts.chattahoocheetech.edu", new Address("940 Cauthen Court NE", "Marietta", "GA", "30066") );
        }

        private void TestStudentClassBtn_Click(object sender, EventArgs e)
        {
            Student s1;
            s1 = new Student("123456789", "Adrian", "Bermudez", "abermud1@studennts.chattahoocheetech.edu", "940 Cauthen Court NE, Marietta, GA, 30066", 4.00d);
        }

        private void TestInsturctorClassBtn_Click(object sender, EventArgs e)
        {
            Instructor i1;
            i1 = new Instructor("123456789", "Ron", "Enz", "renz@chattahoocheetech.edu", "Physical Address is not given to students...", "Not sure which office but I can check the syllabus.");
        }

        private void TestSectionListBtn_Click(object sender, EventArgs e)
        {
            Section sList = new Section();
            sList.addSection(new Section("CIST 1305", "Intro to OOP", "Example", "Example", "Example"));
            sList.addSection(new Section("CIST 1305", "Intro to OOP", "Example", "Example", "Example"));
            sList.display();
        }
    }
}
