using System;
using System.Collections.Generic;

namespace AssignmentDay28
{
    class Program
    {
        public static Dictionary<string, List<UC9>> addressBook = new Dictionary<string, List<UC9>>();
        public static Dictionary<string, List<UC9>> City = new Dictionary<string, List<UC9>>();
        public static Dictionary<string, List<UC9>> State = new Dictionary<string, List<UC9>>();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to Address Book System");
            Console.WriteLine("Enter the number of address books: ");
            int noOfAddressBook = Convert.ToInt32(Console.ReadLine());
            int noOfBooks = 0;
            while (noOfBooks < noOfAddressBook)
            {
                Console.WriteLine("Enter the address book name : ");
                string addressbookname = Console.ReadLine();
                UC9 addressBook = new UC9();
                Console.WriteLine("Enter the no of contacts in the address book: ");
                int noOfContact = Convert.ToInt32(Console.ReadLine());

                while (noOfContact > 0)
                {
                    Console.WriteLine("Enter the details of contact to be added: ");

                    Console.Write("Enter First Name: ");
                    string FirstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    string LastName = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    string PhoneNumber = Console.ReadLine();

                    Console.Write("Enter Address : ");
                    string Addresses = Console.ReadLine();

                    Console.Write("Enter City : ");
                    string City = Console.ReadLine();

                    Console.Write("Enter State : ");
                    string State = Console.ReadLine();

                    Console.Write("Enter ZipCode: ");
                    string ZipCode = Console.ReadLine();

                    Console.Write("Enter EmailId: ");
                    string EmailId = Console.ReadLine();
                    addressBook.GetCustomer(FirstName, LastName, PhoneNumber, Addresses, City, State, ZipCode, EmailId);
                    noOfContact--;

                    Console.WriteLine(" ");
                    addressBook.ListContact();
                }
                Console.WriteLine("1.To Edit/Modify the Contact  details");
                Console.WriteLine("2.To  Delete/remove the Contact  details");
                Console.WriteLine("If You Want TO Serach Or View Contact BY City Or State CLick 3.option");
                Console.WriteLine("3.city or state");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBook.EditContact();
                        Console.WriteLine(" ");
                        addressBook.ListContact();
                        break;
                    case 2:
                        addressBook.DeletePeople();
                        Console.WriteLine(" ");
                        addressBook.ListContact();
                        break;
                    case 3:
                        Console.WriteLine("Enter 1-To Search a person through a City");
                        Console.WriteLine("Enter 2-To Search a person through a State");
                        Console.WriteLine("Enter 3-To view a person by state list or city list");
                        int opt = Convert.ToInt32(Console.ReadLine());
                        switch (opt)
                        {

                            case 1:
                                SearchAddress(opt);
                                break;
                            case 2:
                                SearchAddress(opt);
                                break;
                            case 3:
                                UC9.CountCityorState();

                                break;
                            default:
                                Console.WriteLine("Invalid Option!");
                                break;
                        }
                        break;
                }
                if (addressBook.ContainsKey(addressbookname))
                {
                    Console.WriteLine("Existing address book name");
                    return;
                }
                else
                {
                    addressBook.Add(addressbookname, addressBook.people);
                }
                noOfBooks++;
                foreach (KeyValuePair<string, List<UC9>> addr in addressBook)
                {
                    Console.WriteLine("The address Books are:{0}", addr.Key);

                }
            }
            static void SearchAddress(int option)
            {
                string city, state;
                if (option == 1)
                {
                    Console.WriteLine("Enter the City Name");
                    city = Console.ReadLine();
                    foreach (KeyValuePair<string, List<UC9>> kvp in addressBook)
                    {
                        UC9.StoreCityList(kvp.Key, kvp.Value, city);

                    }
                    if (option == 2)
                    {
                        Console.WriteLine("Enter the City Name");
                        state = Console.ReadLine();
                        foreach (KeyValuePair<string, List<UC9>> kvp in addressBook)
                        {
                            UC9.StoreStateList(kvp.Key, kvp.Value, state);
                        }
                    }
                }
            }
        }

    }
}