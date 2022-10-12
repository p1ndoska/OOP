using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class publishingHouse
    {
        public string publisherName { get { return publisherName; } set { publisherName = value; } }
    }
    public publishingHouse(string publisherName)
    {
        this.publisherName = publisherName;
    }
}
