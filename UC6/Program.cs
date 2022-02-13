using System;

namespace AssignmentDay28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program");
            Console.WriteLine("1.Enter to add the details\n2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove or Delete the Contact details");
            Console.WriteLine("Enter a option");
            UC6 addressbook = new UC6();
            switch (Console.ReadLine())
            {
                case "1":
                    UC5.GetContact();
                    UC5.ListContact();

                    break;
                case "2":
                    UC5.GetContact();
                    UC5.EditContact();
                    UC5.ListContact();
                    break;
                case "3":
                    UC5.GetContact();
                    UC5.ListContact();
                    break;
                case "4":
                    UC5.GetContact();
                    UC5.DeletePeople();

                    break;
                case "5":
                    UC5.GetContact();
                    UC5.ListContact();
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
        }
    }
}