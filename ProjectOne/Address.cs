using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**************************************************************

Adrian Bermudez

Lab #2 - Aug 24, 2020

I wrote this code myself...

**************************************************************/
namespace ProjectOne
{
    class Address
    {


        //*******************************Properties****************************************
        private string Street;
        private string City;
        private string State;
        private string Zip;

        //*******************************Constructors**************************************
        public Address()
        {

            string Street = "";
            string City = "";
            string State = "";
            string Zip = "";

        }
        //constructor built
        public Address(string street, string city, string state, string zip)
        {

            Street = street;
            City = city;
            State = state;
            Zip = zip;

        }


        //*******************************Behaviors*****************************************
        //get and set
        public void setStreet(string street)
        {
            Street = street;

        }

        public string getStreet()
        {

            return Street;

        }

        public void setCity(string city)
        {
            City = city;

        }

        public string getCity()
        {

            return City;

        }
        public void setState(string state)
        {
            State = state;

        }

        public string getState()
        {

            return State;

        }
        public void setZip(string zip)
        {
            Zip = zip;

        }

        public string getZip()
        {

            return Zip;

        }
        //display method to display test information
        public void display()
        {
            Console.WriteLine("Street = " + Street);
            Console.WriteLine("City = " + City);
            Console.WriteLine("State = " + State);
            Console.WriteLine("Zip = " + Zip);




        }





    }
}
