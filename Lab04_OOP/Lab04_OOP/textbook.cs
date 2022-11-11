using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab04_OOP
{
    sealed class Textbook : PrintedEdition
    {
        public string binding;
        public string subject;
        public int gradeNumber;
        public Textbook(string binding, string subject, int gradeNumber, int numberOfPage, string title, int price, string publisherName, string pubishingAdress) : base(numberOfPage, title, price, publisherName, pubishingAdress)
        {
            this.binding = binding;
            this.subject = subject;
            this.gradeNumber = gradeNumber;
            theTotalNumberOfBooks++;
            theTotalCost+=price;
        }
        public override string ToString()
        {
            return base.ToString() + "\nОбложка: " + binding + "\nПредмет: "+ subject + "\nКласс: "+ gradeNumber;
        }
        
    }
}
