using System;

namespace AssignmentDay28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Welcome To Adderess Book Program-------------");
            Console.WriteLine("1.Enter to add the details\n2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove or Delete the Contact details");
            Console.WriteLine("5.Multiple Contact Details /Dictionary Added");
            Console.WriteLine("Enter a option");
            UC7 addressBook = new UC7();
            switch (Console.ReadLine())
            {
                case "1":
                    addressBook.ListContact();
                    break;
                case "2":
                    addressBook.EditContact();
                    addressBook.ListContact();
                    break;
                case "3":
                    addressBook.ListContact();
                    break;
                case "4":
                    addressBook.DeletePeople();
                    break;
                case "5":
                    addressBook.ListContact();
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }

        }
    }
}