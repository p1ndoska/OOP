using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class person : publishingHouse
    {
        public string authorsName;
        public string authorsSurname;
        public person(string authorsName, string authorsSurname, string publisherName, string pubishingAdress) : base (publisherName, pubishingAdress)
        {
            this.authorsName = authorsName;
            this.authorsSurname = authorsSurname;
        }
    }
}
