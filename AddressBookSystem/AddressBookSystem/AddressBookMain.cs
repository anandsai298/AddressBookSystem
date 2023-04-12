using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        List<Contact> AddressList = new List<Contact>();
        Dictionary<string,List<Contact>> ContactDic = new Dictionary<string, List<Contact>> ();
        public AddressBookMain()
        {
            Contact contact1 = new Contact()
            {
                Fn = "ask",
                Ln = "sa",
                Address = "as",
                State = "f",
                City = "kkd",
                ZipCode = "5357",
                PhNo = "123456789",
                Email = "sdfg@ghj"
            };
            Contact contact2 = new Contact()
            {
                Fn = "ask2",
                Ln = "sa2",
                Address = "as2",
                State = "f2",
                City = "kkd2",
                ZipCode = "53572",
                PhNo = "1234567892",
                Email = "sdfg@ghj2"
            };
            AddressList.Add(contact1);
            AddressList.Add(contact2);
            ContactDic.Add("A", AddressList);
            
        }
        public void AddContact()
        {
            string UniqueName=Console.ReadLine();
            Contact contact = new Contact()
            { 
            Fn = Console.ReadLine(),
            Ln = Console.ReadLine(),
            Address = Console.ReadLine(),
            State = Console.ReadLine(),
            City = Console.ReadLine(),   
            ZipCode = Console.ReadLine(),
            PhNo = Console.ReadLine(),
            Email = Console.ReadLine()
            };
            foreach(var data in ContactDic)
            {
                if (data.Key == UniqueName)
                {
                    data.Value.Add(contact);
                    return;
                }
            }
            AddressList.Add(contact);
            ContactDic.Add("UniqueName", AddressList);
            Display(ContactDic);
        }

        public void Display(Dictionary<string, List<Contact>>contacts)
        {
            foreach(var data in contacts) 
            { 
                Console.WriteLine(data.Key);
                foreach(var contact in data.Value)
                {
                    Console.WriteLine("First Name--->" + contact.Fn + "\n" + "Last Name--->" + contact.Ln + "\n" + "Address--->" + contact.Address + "\n" + "State--->" + contact.State + "\n" + "City--->" + contact.City + "\n" + "ZipCode--->" + contact.ZipCode + "\n" + "Phone Number--->" + contact.PhNo + "\n" + "Email Id--->" + contact.Email);
                }
            }
            
        }
        public void Edit_Contact(string UniqueName,string contactname)
        {
            Console.WriteLine("Edit using First Name");
            string name = Console.ReadLine();
            foreach(var data in ContactDic) 
            {
                if (data.Key.Equals(UniqueName))
                {
                    foreach(var contact in data.Value)
                    {
                        if(contact.Fn == contactname)
                        {
                            Console.WriteLine("Enter option to edit \n1.First Name\n2.Last Name\n3.Address\n4.State\n5.City\n6.ZipCode\n7.Phone Number\n8.Email Id");
                            int op = Convert.ToInt32(Console.ReadLine());
                            switch (op)
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
            }
            Display(ContactDic);
        }
        public void Delete_Contact(string UniqueName, string contactname)
        {
            Console.WriteLine("Edit using First Name");
            Contact contact = new Contact();
            string name = Console.ReadLine();
            foreach (var data in ContactDic)
            {
                if (data.Key.Equals(UniqueName))
                {
                    foreach (var item in data.Value)
                    {
                        if (item.Fn == contactname)
                        {
                            contact = item;
                            AddressList = data.Value;
                        }
                    }
                }
            }
            if (contact == null)
                Console.WriteLine("no contact exits in firstname");
            else
                AddressList.Remove(contact);
            Display(ContactDic);
        }
    }
}
