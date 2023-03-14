using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        Contact contact = new Contact();//global declaration
        public void AddContact()
        {
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
        public void Display()
        {
            Console.WriteLine(contact.Fn + "\n" + contact.Ln + "\n" + contact.Address + "\n" + contact.State + "\n" + contact.City + "\n" + contact.ZipCode + "\n" + contact.PhNo + "\n" + contact.Email);
        }
    }
}
