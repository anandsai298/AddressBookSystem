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
            Console.WriteLine("First Name--->"+contact.Fn + "\n" + "Last Name--->"+ contact.Ln + "\n" +"Address--->"+ contact.Address + "\n" +"State--->"+ contact.State + "\n" +"City--->"+ contact.City + "\n" +"ZipCode--->"+ contact.ZipCode + "\n" + "Phone Number--->"+contact.PhNo + "\n" +"Email Id--->"+ contact.Email);
        }
        public void Edit_Contact()
        {
            Console.WriteLine("Enter option to edit \n1.First Name\n2.Last Name\n3.Address\n4.State\n5.City\n6.ZipCode\n7.Phone Number\n8.Email Id");
            int op = Convert.ToInt32(Console.ReadLine());
            switch(op)
            {
                case 1:
                    contact.Fn = Console.ReadLine();
                    break;
                case 2:
                    contact.Ln = Console.ReadLine();
                    break;
                case 3:
                    contact.Address = Console.ReadLine();
                    break;
                case 4:
                    contact.State = Console.ReadLine();
                    break;
                case 5:
                    contact.City = Console.ReadLine();
                    break;
                case 6:
                    contact.ZipCode = Console.ReadLine();
                    break;
                case 7:
                    contact.PhNo = Console.ReadLine();
                    break;
                case 8:
                    contact.Email = Console.ReadLine();
                    break;
            }
        }
    }
}
