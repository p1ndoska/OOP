using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop10
{
    internal class Book
    {
        public string Author;
        public int JearOfPublishing;
 
        public int NumberOfPage;
        public int price;

        public Book(string author, int jearOfPublishing, int numberOfPage, int price)
        {
            Author = author;
            JearOfPublishing = jearOfPublishing;
            NumberOfPage = numberOfPage;
            this.price = price;
        }
    }
}
