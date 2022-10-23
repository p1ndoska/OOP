using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
     abstract class printedEdition : author
    {
        public int numberOfPage { get { return numberOfPage; } set { numberOfPage = value; } }
        public string title { get { return title; } set { title = value; } }
        public int price { get { return price; } set { price = value; } }
        public printedEdition(int numberOfPage, string title, int price, string gener, string publisherName, string pubishingAdress) :base (gener, publisherName, pubishingAdress)
        {
            this.numberOfPage = numberOfPage;
            this.title = title;
            this.price = price;
        }
    }
}
