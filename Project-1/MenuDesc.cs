using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public static class MenuDesc
    {
        public static void MainMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğinizi seçiniz :)");
            Console.WriteLine("*************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
        }

        public static void AddContactMenu()
        {
            Console.WriteLine("Lütfen isim giriniz: ");
            Console.WriteLine("Lütfen soyisim giriniz: ");
            Console.WriteLine("Lütfen telefon numarası giriniz: ");
        }

        public static void RemoveSearchMenu()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
        }

        public static void RemoveSuccessMenu(Contact contact)
        {
            Console.WriteLine("{0} isimli kişiyi rehberden silinmek üzere, onaylıyor musunuz? (y/n)", contact.name);
        }

        public static void RemoveFailMenu()
        {
            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız");
            Console.WriteLine("* Silmeyi sonlandırmak için: (1)");
            Console.WriteLine("* Yeniden denemek için: (2)");
        }

        public static void UpdateSearchMenu()
        {
            Console.WriteLine("Lütfen numarasını değiştirmek istediğiniz kişinin adını ya da soyadını giriniz: ");
        }

        public static void UpdateConfirmMenu(Contact contact)
        {
            Console.WriteLine("{0} isimli kişinin numarası değişmek üzere, onaylıyor musunuz? (y/n)", contact.name);
        }

        public static void UpdateFailMenu()
        {
            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız");
            Console.WriteLine("* Değiştirmeyi sonlandırmak için: (1)");
            Console.WriteLine("* Yeniden denemek için: (2)");
        }

        public static void SearchMenu()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("***********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
        }


    }
}
