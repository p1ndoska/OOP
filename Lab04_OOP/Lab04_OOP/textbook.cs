using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class textbook : printedEdition
    {
        public string binding;
        public string subject;
        public int gradeNumber;
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
