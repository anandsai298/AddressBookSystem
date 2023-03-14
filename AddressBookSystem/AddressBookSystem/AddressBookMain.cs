using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        List<Contact> addressbook = new List<Contact>();
        public void AddContact()
        {
            Contact contact = new Contact();//local
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
            addressbook.Add(contact);
        }
        public void Display()
        {
            foreach(var contact in addressbook) 
            { 
            Console.WriteLine("First Name--->"+contact.Fn + "\n" + "Last Name--->"+ contact.Ln + "\n" +"Address--->"+ contact.Address + "\n" +"State--->"+ contact.State + "\n" +"City--->"+ contact.City + "\n" +"ZipCode--->"+ contact.ZipCode + "\n" + "Phone Number--->"+contact.PhNo + "\n" +"Email Id--->"+ contact.Email);
            }
        }
        public void Edit_Contact()
        {
            Console.WriteLine("Edit using First Name");
            string name = Console.ReadLine();
            foreach(var data in addressbook) 
            {
                if (data.Fn == name) 
                { 
                    Console.WriteLine("Enter option to edit \n1.First Name\n2.Last Name\n3.Address\n4.State\n5.City\n6.ZipCode\n7.Phone Number\n8.Email Id");
                    int op = Convert.ToInt32(Console.ReadLine());
                    switch(op)
                    {
                        case 1:
                            data.Fn = Console.ReadLine();
                            break;
                        case 2:
                            data.Ln = Console.ReadLine();
                            break;
                        case 3:
                            data.Address = Console.ReadLine();
                            break;
                        case 4:
                            data.State = Console.ReadLine();
                            break;
                        case 5:
                            data.City = Console.ReadLine();
                            break;
                        case 6:
                            data.ZipCode = Console.ReadLine();
                            break;
                        case 7:
                            data.PhNo = Console.ReadLine();
                            break;
                        case 8:
                            data.Email = Console.ReadLine();
                            break;
                    }
                }
            }
        }
        public void Delete_Contact()
        {
            Console.WriteLine("Enter name to delete contact");
            string name = Console.ReadLine();
            foreach (var data in addressbook)
            {
                if(data.Fn.Equals(name))
                {
                    addressbook.Remove(data);
                }
            }

        }
    }
}
