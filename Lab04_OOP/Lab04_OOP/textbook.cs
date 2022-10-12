using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class textbook : printedEdition
    {
        public string binding { get { return binding; } set { binding = value; } }
        public string subject { get { return subject; } set { subject = value; } }
        public string gradeNumber { get { return gradeNumber; } set { gradeNumber = value; } }
        public textbook(string Binding, string subject, string gradeNumber, int numberOfPage, string title, int price) : base(numberOfPage, title, price)
        {

        }
    }
}
