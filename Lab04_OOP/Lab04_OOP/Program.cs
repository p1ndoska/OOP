using System;
using System.Collections.Generic;
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
            

            Book Object1 = new Book(1990, "И. А. Бродский", "неизвестно", "мягкая обложка", 224, "Набережная неисцелимых", 9, "Лениздат", "проспект Победителей, 3");
            Console.WriteLine(Object1);

            Console.WriteLine("---------------------------------------------------");

            Book Object4 = new Book(2006, "В. Пелевин", "Азбука-классика", "мягкая обложка", 320, "Generation «П» ", 12, "Азбука", "неизвестно");
            Console.WriteLine(Object1);

            Console.WriteLine("---------------------------------------------------");

            Book Object5 = new Book(1950, "М. Булгаков", "Русская классика", "мягкая обложка", 256, "Морфий", 7, "АСТ", "неизвестно");
            Console.WriteLine(Object1);

            Console.WriteLine("---------------------------------------------------");

            Book Object6 = new Book(2002, "Рэй Бредбери", "Всемирная литература", "твердая обложка", 320, "451 по фарингейту", 10, "Эксмо", "неизвестно");
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
            Console.WriteLine("---------------------------------------------------");
            //int[] Library = new object[];
            //список "библиотека"
            //List<object> library = new List<object>() { };
            //library.Add(Object1);
            //library.Add(Object2);
            //library.Add(Object3);

            //foreach (var item in library)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------");
            //library.RemoveAt(2);
            //foreach (var item in library)
            //{
            //    Console.WriteLine(item);
            //}

            Container Librarys = new Container();
            Librarys.Add(Object3);
            Librarys.Add(Object2);
            Librarys.Add(Object1);
            Librarys.PrintElems();
            Controller controller = new Controller();
            controller.TotalCost(Librarys);
            controller.Sum(Librarys);
            controller.PrintTitle(Librarys, 1200);
        }
    }
}
