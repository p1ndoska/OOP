using System;

namespace Lab04_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            author author = new author("роман","Эскмо", " Россия, Москва, ул. Зорге, 1c1", "Виктор", "Пелевин");
            Console.WriteLine(author);

            Console.WriteLine("---------------------------------------------------");

            PublishingHouse Object = new PublishingHouse("ACT", "проспект Жукова, 34");
            

            book Object1 = new book("И. А. Бродский", "неизвестно", "мягкая обложка", 224, "Набережная неисцелимых", 9, "Лениздат", "проспект Победителей, 3");
            Console.WriteLine(Object1);

            Console.WriteLine("---------------------------------------------------");

            textbook Object2 = new textbook("твердая", "физика", 11, 500, "Учебник по физике", 13, "Аверсэв", "Олешева 1");
            Console.WriteLine(Object2);

            Console.WriteLine("---------------------------------------------------");


            magazine Object3 = new magazine("раз в год", "наука и техника", 300, "Собака.ru", 23, "Редакция", "проспект Независимости, 10");
            Console.WriteLine(Object3);

            Console.WriteLine("---------------------------------------------------");

            PublishingHouse.getInfo();

            Console.WriteLine("---------------------------------------------------");

            Object1.YaAbstraktniyClass();
            Object1.LeaveFeedback();
            Object1.Gotovo();
            Object.Gotovo();

            Console.WriteLine("---------------------------------------------------");

            PublishingHouse pb = Object1 as PublishingHouse;
            Console.WriteLine(author is person);

            
            Object.KtoYa();

            IPrintInfo IPI = Object1;
            IPI.KtoYa();

            object[] objects = { Object, IPI, Object1, Object2 };

            foreach (var item in objects)
            {

                Printer.IAmPrinting(item);

            }
        }
    }
}
