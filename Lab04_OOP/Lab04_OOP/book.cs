using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Text;

namespace Lab04_OOP
{
    class book : printedEdition, IPrintInfo
    {
        public string author;
        public string series;
        public string binding;
        public book(string author, string series, string binding, int numberOfPage, string title, int price, string publisherName, string pubishingAdress) : base(numberOfPage, title, price, publisherName, pubishingAdress)
        {
            this.author = author;
            this.series = series;
            this.binding = binding;
            theTotalNumberOfBooks++;
            theTotalCost+=price;
        }

        public new void LeaveFeedback()
        {
            Console.WriteLine($"Оставьте отзыв о книге :{title}");
            Console.ReadLine();
            Console.WriteLine("Спасибо, ваш отзыв очень важен для нас");
        }


        public override string ToString()
        {
            return base.ToString() + "\nАвтор: " + author +"\nСерия: " + series +"\nОбложка" + binding;
        }

        public override void Gotovo()
        {
            Console.WriteLine("Не готово!");

        }

    }
}
