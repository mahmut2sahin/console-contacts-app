using System;

namespace Project_1
{
    class Program
    {
        static void Main()
        {
            Contacts contacts = new();
            while (true)
            {
                MenuDesc.MainMenu();
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        contacts.AddContact();
                        break;
                    case "2":
                        contacts.RemoveContact();
                        break;
                    case "3":
                        contacts.UpdateContact();
                        break;
                    case "4":
                        contacts.ListContacts();
                        break;
                    case "5":
                        MenuDesc.SearchMenu();
                        Console.ReadLine();
                        contacts.FindContact();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

