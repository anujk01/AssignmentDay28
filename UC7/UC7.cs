using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentDay28
{
    public interface IAddressBook
    {
        void ListContact();
        void DeletePeople();
    }
    public class UC7 : IAddressBook
    {
        public List<UC7> people;
        public UC7()
        {
            people = new List<UC7>();
        }
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zipCode;
        public string phoneNum;
        public string emailId;
        public UC7(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zip;
            this.phoneNum = phoneNumber;
            this.emailId = email;

        }

        public void GetCustomer(string firstName, string lastName, string phoneNum, string address, string city, string state, string zipCode, string emailId)
        {

            UC7 person = new UC7(firstName, lastName, phoneNum, address, city, state, zipCode, emailId);
            if (people.Count == 0)
            {
                people.Add(person);
            }
            else
            {
                UC7 people = this.people.Find(a => a.firstName.Equals(firstName));
                if (people == null)
                {
                    UC7 p = new UC7(firstName, lastName, address, city, state, phoneNum, zipCode, emailId);
                    this.people.Add(p);
                }
                else
                {
                    Console.WriteLine("-------Record is already exists-------");
                    Console.WriteLine("Modify the details which has duplicate name");
                    EditContact();
                }
            }
        }

        public void PrintContact(UC7 person)
        {
            Console.WriteLine("First Name: " + person.firstName);
            Console.WriteLine("Last Name: " + person.lastName);
            Console.WriteLine("Phone Number: " + person.phoneNum);
            Console.WriteLine("Address : " + person.address);
            Console.WriteLine("City : " + person.city);
            Console.WriteLine("State : " + person.state);
            Console.WriteLine("ZipCode : " + person.zipCode);
            Console.WriteLine("Phone Number: " + person.phoneNum);
            Console.WriteLine("Email Id: " + person.emailId);
            Console.WriteLine("-------------------------------------------");
        }
        public void EditContact()
        {
            if (people.Count != 0)
            {
                Console.WriteLine("Enter the contact to modify:");
                string Modified = Console.ReadLine();
                foreach (var person in people)
                {
                    if (person.firstName.ToUpper() == Modified.ToUpper())
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the option to modify the property: ");
                            Console.WriteLine("Enter 1 to Change First name ");
                            Console.WriteLine("Enter 2 to Change Last name ");
                            Console.WriteLine("Enter 3 to Change Phone Number ");
                            Console.WriteLine("Enter 4 to Change Address ");
                            Console.WriteLine("Enter 5 to Change City ");
                            Console.WriteLine("Enter 6 to Change State ");
                            Console.WriteLine("Enter 7 to Change Pincode ");
                            Console.WriteLine("Enter 8 to Exit ");
                            int Check = Convert.ToInt32(Console.ReadLine());
                            switch (Check)
                            {
                                case 1:
                                    Console.WriteLine("Enter the New First Name: ");
                                    person.firstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the New Last Name: ");
                                    person.lastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the New Phone Number: ");
                                    person.phoneNum = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the New Address: ");
                                    person.address = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the New City: ");
                                    person.city = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the New State: ");
                                    person.state = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the New Pin Code: ");
                                    person.zipCode = Console.ReadLine();
                                    break;
                                case 8:
                                    return;

                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("Enter the valid name!");
                    }

                }

            }
        }


        public void ListContact()
        {
            if (people.Count == 0)
            {
                Console.WriteLine("Your address book is empty.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("The Contacts In address book:\n");
            foreach (var person in people)
            {
                PrintContact(person);
            }
            return;

        }

        public void DeletePeople()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string firstName = Console.ReadLine();
            UC7 person = people.FirstOrDefault(x => x.firstName.ToUpper() == firstName.ToUpper());
            if (person == null)
            {
                Console.WriteLine("That person could not be found..");

                return;
            }
            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");


            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                people.Remove(person);
                Console.WriteLine("\nPerson removed ");

            }

        }
    }
}