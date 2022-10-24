using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class book : printedEdition
    {
        public string author;
        public string series;
        public string binding;
        public book(string author, string series, string binding, int numberOfPage, string title, int price, string publisherName, string pubishingAdress, string gener) : base(numberOfPage, title, price, publisherName, pubishingAdress, gener)
        {
            this.author = author;
            this.series = series;
            this.binding = binding;
            theTotalNumberOfBooks++;
            theTotalCost++;
        }
    }
}
