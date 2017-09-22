using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        private string firstName;
        private string lastName;
        private string birthDate;
        private string homeAddress;
        private string socialNumber;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }
        public string HomeAddress
        {
            get { return this.homeAddress; }
            set { this.homeAddress = value; }
        }
        public string SocialNumber
        {
            get { return this.socialNumber; }
            set { this.socialNumber = value; }
        }
        public Client()
        {

        }

        public Client(string firstName, string lastName, string birthDate, string homeAddress, string socialNumber)
        {
            this.firstName = "Tyler";
            this.lastName = "Graves";
            this.birthDate = "July 26 1990";
            this.homeAddress = "1426 Imaginary Ave";
            this.socialNumber = "135-79-2468";

        }
        public void showInfo()
        {
            Console.WriteLine(firstName  + lastName + "\n" + birthDate + "\n" +  homeAddress + "\n" +   socialNumber);
        }
    }
}
