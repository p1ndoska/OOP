using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class person : publishingHouse
    {
        public string authorsName { get { return authorsName; } set { authorsName = value; } }
        public string authorsSurname { get { return authorsSurname; } set { authorsSurname = value; } }
        public person(string authorsName, string authorsSurname, string publisherName, string pubishingAdress) : base (publisherName, pubishingAdress)
        {
            this.authorsName = authorsName;
            this.authorsSurname = authorsSurname;
        }
    }
}
