using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab04_OOP
{
    class Magazine : PrintedEdition
    {
        public string releaseFrequency;
        public string themes;
        public Magazine(string releaseFrequency, string themes, int numberOfPage, string title, int price, string publisherName, string pubishingAdress) :base (numberOfPage, title, price, publisherName, pubishingAdress)
        {
            this.releaseFrequency = releaseFrequency;
            this.themes = themes;
            theTotalNumberOfBooks++;
            theTotalCost+=price;
        }

        public override string ToString()
        {
            return base.ToString() + "\nГод выпуска: " + releaseFrequency+"\nТема: "+themes;
        }


    }
}
