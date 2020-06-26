using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Book
    {
        private string Avtor;
        private string Nazvanie;
        private int Kolichestvo;
        private bool Collection;




        public Book(string Avtor, bool Collection)
        {
            this.Avtor = Avtor;
            this.Collection = Collection;
        }


        public Book(string Avtor, string Nazvanie, int Kolichestvo, bool Collection)
        {
            this.Avtor = Avtor;
            this.Nazvanie = Nazvanie;
            this.Kolichestvo = Kolichestvo;
            this.Collection = Collection;
        }
        public void Printout
            ()
        {
            Console.WriteLine("Автор - " + Avtor);
            Console.WriteLine("Название книги - " + Nazvanie);
            Console.WriteLine("Кол-во страниц - " + Kolichestvo);
            Console.WriteLine("Коллекционное издание -- " + Collection);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Только автор и коллекционное ли?\n2 -Заполнить всё");
            int Num = Convert.ToInt32(Console.ReadLine());

            if (Num == 1)
            {
                Book newBook1 = new Book("Автор", true);
                newBook1.Printout();
            }
            else if (Num == 2)
            {
                Book newBook2 = new Book("Автор", "название", 100, true);
                newBook2.Printout();
            }
            Console.ReadLine();
        }
    }
}
