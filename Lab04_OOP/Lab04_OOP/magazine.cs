using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class magazine : printedEdition
    {
        public string releaseFrequency;
        public string themes;
        public magazine(string releaseFrequency, string themes, int numberOfPage, string title, int price, string publisherName, string pubishingAdress, string gener) :base (numberOfPage, title, price, publisherName, pubishingAdress, gener)
        {
            this.releaseFrequency = releaseFrequency;
            this.themes = themes;
            theTotalNumberOfBooks++;
            theTotalCost++;
        }
    }
}
