// See https://aka.ms/new-console-template for more information
using System;
namespace AddressBookSystem
{
    class program
    {
        static void Main(String[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("1.Add_Contact\n2.EditContact\n3.DeleteContact");
                Console.WriteLine("Enter option to display option");
                int option = Convert.ToInt32(Console.ReadLine());
                AddressBookMain ABM = new AddressBookMain();
                switch (option)
                {
                    case 1:
                        for (int i = 0; i < 2; i++) 
                        {
                        ABM.AddContact();
                        }
                        ABM.Display();
                        break;
                    case 2:
                        ABM.Edit_Contact();
                        ABM.Display();
                        break;
                    case 3:
                        ABM.Delete_Contact();
                        ABM.Display();
                        break;
                }
            }
        }
    }
}