using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab04_OOP
{
    class person : PublishingHouse
    {
        public string authorsName;
        public string authorsSurname;
        public person(string authorsName, string authorsSurname, string publisherName, string pubishingAdress) : base (publisherName, pubishingAdress)
        {
            this.authorsName = authorsName;
            this.authorsSurname = authorsSurname;
        }
        public override string ToString()
        {
            return base.ToString() + "\nИмя автора: " + authorsName +"\nФамилия автора: " + authorsSurname;
        }
    }
}
