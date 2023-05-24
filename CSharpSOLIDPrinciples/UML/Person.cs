using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class Person
    {
        public Person()
        {

        }        

        public Person(string firstName, string lastName, DateTime dateOfBirth, string? email)
        {
            if (String.IsNullOrEmpty(firstName))
            {
                throw new ArgumentNullException("First name cannot be empty!");
            }

            if (String.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException("Last name cannot be empty!");
            }

            if (dateOfBirth < DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("Date of birth is not valid!");
            }

            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
        }

        private string firstName;
        public string FirstName { 
            get => this.firstName; 
            private set => this.firstName = value;
        }

        private string lastName;
        public string LastName
        {
            get => this.lastName;
            private set => this.lastName = value;
        }

        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get => this.dateOfBirth;
            private set => this.dateOfBirth = value;
        }

        private string? email;
        public string? Email
        {
            get => this.email;
            private set => this.email = value;
        }

        public void IdentifyPerson()
        {
            Console.Write($"This person is {this.firstName} ${this.lastName}!");
        }

        public void VerifyPerson()
        {
            Console.Write($"Person {this.firstName} ${this.lastName} has been verified!");
        }
    }
}
