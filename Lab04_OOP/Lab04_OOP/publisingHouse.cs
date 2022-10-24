using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class publishingHouse
    {
        ////////////////////////////////////////////////////////////////
        public static void getInfo()
        {
            Console.WriteLine($"Всего книг: {theTotalNumberOfBooks}");
            Console.WriteLine($"Цена книг: {theTotalCost}");
        }
        ////////////////////////////////////////////////////////////////
        //private string number = "10";
        public string Number { get; set; }
        public static int theTotalCost = 0;
        public static int theTotalNumberOfBooks;
        public string publisherName;
        public string pubishingAdress;
        public publishingHouse(string publisherName, string pubishingAdress)
        {
            this.publisherName = publisherName;
            this.pubishingAdress = pubishingAdress;
        }

        public override string ToString()
        {
            return base.ToString() + " " + publisherName.ToString() + " " + pubishingAdress.ToString();
        }

        //public override int GetHashCode()
        //{
        //    return Number.GetHashCode();
        //}

        //public override bool Equals(object obj)
        //{
        //    if (obj.GetType() != this.GetType()) return false;
        //    return true;
        //}
    }
}
