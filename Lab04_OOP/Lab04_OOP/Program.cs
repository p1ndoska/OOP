using System;
using System.Collections;
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

            Console.WriteLine("\n\n\n ________________Для лабораторной работы №7_________________\n");

            /// Объект класса принимает значение NULL
            try
            {
                object obj = "String";
                //Computer Comp = new Computer();
                Book Book = obj as Book;
                if (Book == null)
                {
                    throw new NullObject();     /// Исключение может быть сгенерировано вручную
                }
            }
            catch (NullObject e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                e.PrintInfo();
            }


            /// Несуществующая дата
            try
            {
                Magazine check = new Magazine("раз в год","наука и техника", 94423456,"VOGUE",32,"лениздат","кирова");
                if (check.numberOfPage > 31129999)
                {
                    throw new WrongDate("Несуществующее количество страниц!");
                }
            }
            catch (WrongDate e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                e.PrintInfo();
            }


            /// Член класса не инициализирован
            try
            {
                Textbook my_tablet = new Textbook("мягкий","математика",0,123,"учебник по математике",44,"самиздат","вилейка");
                if (my_tablet.gradeNumber == 0)
                {
                    throw new EmptyStruct();
                }
            }

            catch (EmptyStruct e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                e.PrintInfo();
            }


            /// Деление на 0
            try
            {
                int x = 5, y = 0;
                int c = x / y;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message + "\n");
            }


            ///// Выход за границы массива
            //try
            //{
            //    int[] arr = new int[8];
            //    arr[10] = 10;
            //}
            //catch (Exception e)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(e.Message + "\n");
            //}


            //finally     /// Необязательный элемент. Finally-Блок всегда выполняется,
            //            /// когда выполнение покидает любую часть Try...Catch инструкции
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("\tFINALLY > Обязательное выполнение данного кода \n");
            //}
        }
    }
}
