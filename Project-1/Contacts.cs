using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Project_1
{
    public class Contacts
    {

        List<Contact> contacts = new List<Contact>()
        {
            new Contact() {name= "Allen", surname= "Iverson", telno= "5304657952"},
            new Contact() {name= "Tracy", surname= "McGrady", telno= "5424570522"},
            new Contact() {name= "Yao", surname= "Ming", telno= "5354648952"},
            new Contact() {name= "Stephen", surname= "Curry", telno= "5509957957"},
            new Contact() {name= "Dirk", surname= "Nowitzki", telno= "5554235732"}
        };

        public void AddContact()
        {
            Contact newContact = new();
            Console.Write("Lütfen isim giriniz: ");
            newContact.name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz: ");
            newContact.surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz: ");
            newContact.telno = Console.ReadLine();
            contacts.Add(newContact);
        }

        public void RemoveContact()
        {
            MenuDesc.RemoveSearchMenu();
            string input = Console.ReadLine();
            var toRemove = contacts.Find(i => i.name == input || i.surname == input);
            if (toRemove != null)
            {
                MenuDesc.RemoveSuccessMenu(toRemove);
                input = Console.ReadLine();
                switch (input)
                {
                    case "y":
                        contacts.Remove(toRemove);
                        break;
                    case "n":
                        break;
                }
            }
            else
            {
                MenuDesc.RemoveFailMenu();
                string input2 = Console.ReadLine();
                switch (input2)
                {
                    case "1":
                        break;
                    case "2":
                        RemoveContact();
                        break;
                }
            }
        }
        public void UpdateContact()
        {
            MenuDesc.UpdateSearchMenu();
            string searchKey = Console.ReadLine();
            var toUpdate = contacts.Find(i => i.name == searchKey || i.surname == searchKey);
            if (toUpdate != null)
            {
                Console.WriteLine("Enter the number: ");
                string telno = Console.ReadLine();
                MenuDesc.UpdateConfirmMenu(toUpdate);
                switch (Console.ReadLine())
                {
                    case "y":
                        toUpdate.telno = telno;
                        break;
                    case "n":
                        break;
                }
            }
        }
        public void FindContact()
        {
            Console.Write("Please enter the search key: ");
            string input = Console.ReadLine();
            var foundContacts = contacts.FindAll(i => i.name == input || i.surname == input || i.telno == input);
            if (foundContacts.Count != 0)
            {
                PrintContacts.PrintFoundContacts(foundContacts);
            }
            else
            {
                Console.WriteLine("There is no such a contact!");
            }
        }

        public void ListContacts()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("******************************");
            contacts.ForEach(PrintContacts.PrintOneContact);
        }
    }
}

