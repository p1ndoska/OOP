using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class book : printedEdition
    {
        public string author { get { return author; } set { author = value; } }
        public string series { get { return series; } set { series = value; } }
        public string binding { get { return binding; } set { binding = value; } }
        public book(string author, string series, string binding, int numberOfPage, string title, int price) :base (numberOfPage, title, price)
        {

        }
    }
}
