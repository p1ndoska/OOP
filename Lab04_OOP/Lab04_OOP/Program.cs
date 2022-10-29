using System;
using System.Xml.Linq;
using static Lab04_OOP.PublishingHouse;

namespace Lab04_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("роман","Эскмо", " Россия, Москва, ул. Зорге, 1c1", "Виктор", "Пелевин");
            Console.WriteLine(author);

            Console.WriteLine("---------------------------------------------------");

            PublishingHouse Object = new PublishingHouse("ACT", "проспект Жукова, 34");
            

            Book Object1 = new Book("И. А. Бродский", "неизвестно", "мягкая обложка", 224, "Набережная неисцелимых", 9, "Лениздат", "проспект Победителей, 3");
            Console.WriteLine(Object1);

            Console.WriteLine("---------------------------------------------------");

            Textbook Object2 = new Textbook("твердая", "физика", 11, 500, "Учебник по физике", 13, "Аверсэв", "Олешева 1");
            Console.WriteLine(Object2);

            Console.WriteLine("---------------------------------------------------");


            Magazine Object3 = new Magazine("раз в год", "наука и техника", 300, "Собака.ru", 23, "Редакция", "проспект Независимости, 10");
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
            Console.WriteLine(author is Person);

            
            Object.KtoYa();

            IPrintInfo IPI = Object1;
            IPI.KtoYa();

            object[] objects = { Object, IPI, Object1, Object2 };

            foreach (var item in objects)
            {

                Printer.IAmPrinting(item);

            }

            Console.WriteLine("---------------------------------------------------");

            //вызов enum
            {
                ChoiceAction(ActionChoice.BuyNow);
                //Console.ReadLine();
            }

             static void ChoiceAction(ActionChoice operation)
            {
                Console.WriteLine($"Действие {operation} успешно выполнено!");
            }

            //использование struct
          
        }
    }
}
