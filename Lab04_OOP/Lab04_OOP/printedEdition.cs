using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab04_OOP
{
     abstract class PrintedEdition : PublishingHouse
    {
        public int numberOfPage;
        public string title;
        public int price;
        public PrintedEdition(int numberOfPage, string title, int price, string publisherName, string pubishingAdress) :base (publisherName, pubishingAdress)
        {
            this.numberOfPage = numberOfPage;
            this.title = title;
            this.price = price;
        }

        public override string ToString()
        {
            return base.ToString() + "\nНазвание: " + title +"\nЦена: "+price;
        }




    }
}
