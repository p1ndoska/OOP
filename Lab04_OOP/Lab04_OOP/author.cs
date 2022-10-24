using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class author:publishingHouse
    {
        public string gener;
        public author(string gener, string publisherName, string pubishingAdress):base (publisherName, pubishingAdress)
        {
            this.gener = gener;
        }
}
}
