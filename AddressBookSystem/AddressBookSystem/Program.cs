// See https://aka.ms/new-console-template for more information
using System;
namespace AddressBookSystem
{
    class program
    {
        static void Main(String[] args)
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter First Name ");
            contact.Fn = Console.ReadLine();
            Console.WriteLine("Enter Last Name ");
            contact.Ln = Console.ReadLine();
            Console.WriteLine("Enter Address ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter State ");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter City ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter ZipCode ");
            contact.ZipCode = Console.ReadLine();
            Console.WriteLine("Enter Phone Number ");
            contact.PhNo = Console.ReadLine();
            Console.WriteLine("Enter Email Id ");
            contact.Email = Console.ReadLine();
        }
    }
}