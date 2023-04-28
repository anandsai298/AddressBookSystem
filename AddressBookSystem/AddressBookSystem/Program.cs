// See https://aka.ms/new-console-template for more information
using Microsoft.Azure.KeyVault.Models;
using System;
using System.Collections.Generic;

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
                Console.WriteLine("1.Add_Contact\n2.EditContact\n3.DeleteContact\n4.SearchWithCity\n5.SearchWithState\n6.Display");
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
                    case 4:
                        ABM.SearchWithCity("kkd");
                        break;
                    case 5:
                        ABM.SearchWithState("ap");
                        break;
                    /*case 6:
                        AddressBookMain.Display(Contact);
                        break;*/
                    case 7:
                        ABM.CountByCity();
                        break;
                    case 8:
                        ABM.CountByState();
                        break;
                }
            }
        }
    }
}