using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class textbook : printedEdition
    {
        public string binding { get { return binding; } set { binding = value; } }
        public string subject { get { return subject; } set { subject = value; } }
        public int gradeNumber { get { return gradeNumber; } set { gradeNumber = value; } }
        public textbook(string binding, string subject, int gradeNumber, int numberOfPage, string title, int price, string publisherName, string pubishingAdress, string gener) : base(numberOfPage, title, price, publisherName, pubishingAdress, gener)
        {
            this.binding = binding;
            this.subject = subject;
            this.gradeNumber = gradeNumber;
            theTotalNumberOfBooks++;
            theTotalCost++;
        }
    }
}
