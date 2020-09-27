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
    class Person 
    {


        //*******************************Properties****************************************
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string physicalAddress;
        private Address a;
        






        //*******************************Constructors**************************************



        //sets fields to blank to test

        public Person()
        {
            string firstName = "";
            string lastName = "";
            string emailAddress = "";
            string physicalAddress = "";
            a = new Address();
             
            


        }
        //create contstructor
        public Person(string first, string last, string email, Address add)
        {

            firstName = first;
            lastName = last;
            emailAddress = email;
            
            a = add;

        }



        //*******************************Behaviors*****************************************

        public void setfirstName(string first)
        {
            firstName = first;

        }

        public string getfirstName()
        {

            return firstName;

        }

        public void setlirstName(string last)
        {
            lastName = last;

        }

        public string getlastName()
        {

            return lastName;

        }
        public void setemailAddress(string email)
        {
            emailAddress = email;

        }

        public string getemailAdress()
        {

            return emailAddress;

        }
       
        internal Address A { get => a; set => a = value; }


        //display method to display the information inputted
        public void Display()
        {

            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name:  " + lastName);
            Console.WriteLine("Email: " + emailAddress);
            a.display();





        }
    }
}
