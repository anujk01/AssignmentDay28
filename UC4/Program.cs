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
            switch (Console.ReadLine())
            {
                case "1":
                    UC4.GetContact();
                    UC4.ListContact();

                    break;
                case "2":
                    UC4.GetContact();
                    UC4.EditContact();
                    UC4.ListContact();
                    break;
                case "3":
                    UC4.GetContact();
                    UC4.ListContact();
                    break;
                case "4":
                    UC4.GetContact();
                    UC4.DeletePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
        }
    }
}