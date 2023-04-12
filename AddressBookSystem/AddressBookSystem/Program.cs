// See https://aka.ms/new-console-template for more information
using System;
namespace AddressBookSystem
{
    class program
    {
        static void Main(String[] args)
        {
            AddressBookMain ABM = new AddressBookMain();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("1.Add_Contact\n2.EditContact\n3.DeleteContact");
                Console.WriteLine("Enter option to display option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        for (int i = 0; i < 2; i++) 
                        {
                        ABM.AddContact();
                        }
                        break;
                    case 2:
                        ABM.Edit_Contact("A","ask");
                        break;
                    case 3:
                        ABM.Delete_Contact("A", "ask");
                        break;
                }
            }
        }
    }
}