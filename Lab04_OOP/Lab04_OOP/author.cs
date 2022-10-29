using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab04_OOP
{
    class Author:Person
    {

        public string gener;
        public Author(string gener, string publisherName, string pubishingAdress, string authorsName, string authorsSurname):base (publisherName, pubishingAdress, authorsName, authorsSurname)
        {
            this.gener = gener;
        }

        public override string ToString()
        {
            return base.ToString() + "\nЖанр: " + gener;
        }
    }
}
