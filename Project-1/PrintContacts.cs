using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class PrintContacts
    {
        public static void PrintOneContact(Contact contact)
        {
            Console.WriteLine("isim: {0}", contact.name);
            Console.WriteLine("Soyisim: {0}", contact.surname);
            Console.WriteLine("Telefon Numarası: {0}", contact.telno);
            Console.WriteLine("-");
        }

        public static void PrintFoundContacts(List<Contact> contacts)
        {
            Console.WriteLine("Arama Sonuçlarınız:");
            Console.WriteLine("******************************");
            contacts.ForEach(PrintOneContact);
        }
    }
}
