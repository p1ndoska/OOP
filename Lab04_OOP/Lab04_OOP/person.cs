using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab04_OOP
{
    class Person : PublishingHouse
    {
        public string authorsName;
        public string authorsSurname;
        public Person(string authorsName, string authorsSurname, string publisherName, string pubishingAdress) : base (publisherName, pubishingAdress)
        {
            this.authorsName = authorsName;
            this.authorsSurname = authorsSurname;
        }
        public override string ToString()
        {
            return base.ToString() + "\nИмя автора: " + authorsName +"\nФамилия автора: " + authorsSurname;
        }

        public struct CustumerInfo
        {
            public string customerName { get; set; }
            public string customerSurname { get; set; }
            public int age { get; set; }

            //public void Print
            //{
            //    Console.WriteLine(customerName   );
            //}
        }
         
 
    }
}
