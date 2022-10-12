using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class magazine : printedEdition
    {
        public string releaseFrequency { get { return releaseFrequency; } set { releaseFrequency = value; } }
        public string themes { get { return themes; } set { themes = value; } }
        public magazine(string releaseFrequency, string themes, int numberOfPage, string title, int price):base (numberOfPage, title, price)
        {

        }
    }
}
