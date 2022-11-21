using System;
using System.Collections.Generic;
using System.Linq;

namespace oop10
{
    class Program
    {
        static void Main( )
        {
            // 1
                string[] months = {"January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December", };

                int n = 4;
                var SelectedMonths1 = from t in months
                                      where t.Length == n
                                      select t;

                var SelectedMonths2 = from t in months
                                      where Equals(t, "December") || Equals(t, "January") || Equals(t, "February")
                                            || Equals(t, "June") || Equals(t, "July") || Equals(t, "August")
                                      select t;

                var SelectedMonths3 = from t in months
                                      orderby t
                                      select t;

                var SelectedMonths4 = from t in months
                                      where t.Contains("u")
                                      where t.Length >= 4
                                      select t;

                foreach (var item in SelectedMonths1)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("_____________________________________");
                foreach (var item in SelectedMonths2)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("_____________________________________");
                foreach (var item in SelectedMonths3)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("_____________________________________");
                foreach (var item in SelectedMonths4)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("_____________________________________");
            Book book1 = new Book("Бродский", 1967, 100, 10);
            Book book2 = new Book("Лермонтов", 1977, 120, 30);
            Book book3 = new Book("Булгаков", 1987, 452, 20);
            Book book4 = new Book("Маяковский", 1995, 180, 150);
            Book book5 = new Book("Толстой", 1945, 190, 17);
            Book book6 = new Book("Есенин", 1998, 900, 19);
            Book book7 = new Book("Ахматова", 1988, 160, 14);
            Book book8 = new Book("Пришвин", 1936, 500, 11);
            Book book9 = new Book("Чехов", 1925, 320, 31);
            Book book10 = new Book("Бродский", 1967, 7550, 56);
            List<Book> list = new List<Book>();
            list.Add(book1);
            list.Add(book2);
            list.Add(book3);
            list.Add(book4);
            list.Add(book5);
            list.Add(book6);
            list.Add(book7);
            list.Add(book8);
            list.Add(book9);
            list.Add(book10);
            var SelectedBooks = from t in list//
                                  where t.Author == "Бродский"
                                  where t.JearOfPublishing == 1967
                                  select t;

            var SelectedBooks2 = from t in list//
                                where t.JearOfPublishing > 1967
                                select t;

            var SelectedBooks3 = from t in list
                               orderby t.NumberOfPage
                                select t;
            var SelectedBook = SelectedBooks3.First();//

            var SelectedBooks4 = from t in list
                                 orderby t.price
                                 orderby t.NumberOfPage
                                 select t;
            var SelectedBooks5 = SelectedBooks4.TakeLast(5);//

            var SelectedBooks6 = from t in list//
                                 orderby t.price
                                 select t;

            foreach (var item in SelectedBooks)
            {
                Console.WriteLine(item.Author + " " + item.JearOfPublishing);
            }
            Console.WriteLine("_____________________________________");
            foreach (var item in SelectedBooks2)
            {
                Console.WriteLine(item.Author+" "+item.JearOfPublishing);
            }
            Console.WriteLine("_____________________________________");
            foreach (var item in SelectedBooks5)
            {
                Console.WriteLine(item.Author + " " + item.JearOfPublishing);
            }
            Console.WriteLine("_____________________________________");
            foreach (var item in SelectedBooks6)
            {
                Console.WriteLine(item.Author + " " + item.JearOfPublishing);
            }
            Console.WriteLine("_____________________________________");
            Console.WriteLine(SelectedBook.Author + " " + SelectedBook.JearOfPublishing);
            Console.WriteLine("_____________________________________");

            var Selected7 = list

                                .OrderBy(n => n.JearOfPublishing)
                                .Where(n => n.NumberOfPage >= 700)
                                .Take(5)
                                .GroupBy(n => n.NumberOfPage)
                                .Last();
            Console.WriteLine(Selected7.Key);
            Console.WriteLine("_____________________________________");

            List<int> Col1 = new List<int>()
            {
                1,2,3,4,5,6
            };
            List<int> Col2 = new List<int>()
            {
                5,6,3,4,9,6
            };
            var Col3 = Col1.Join(Col2, p => p, t => t, (p, t) => p + t);
            foreach (var item in Col3)
            {
                Console.WriteLine(item);
            }
        }
    }
}

