
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    partial class Book
    {
        public Book(string title, string authors)
        {
            this.title = title;
            numberOfPage = 200;
            price = 10;
            this.authors = authors;
            theYearOfPublishing = 2001;
            id = numberOfPage + HASH;
            numberOfBooks++;
        }
        //конструктор без параметром
        public Book()
        {
            title = "Неизвестно";
            authors = "Неизвестно";
            numberOfPage = 0;
            id = numberOfPage + HASH;
            numberOfBooks++;
        }
        //конструктор с параметром по умолчанию
        public Book(string title, int price, int numberOfPage, string authors = "И. А. Бродский")
        {
            this.title = title;
            this.price = price;
            this.numberOfPage = numberOfPage;
            theYearOfPublishing = 2030;
            this.authors = authors;
            id = numberOfPage + HASH;
            numberOfBooks++;
        }
        //статический конструктор
        static Book()
        {
            publishingHouse = "Лениздат";
            bindingType = "неизвестно";
        }

        //приватный конструктор
        private Book(string title)
        {
            this.title = title;
            theYearOfPublishing = 1984;
            id = numberOfPage + HASH;
            numberOfBooks++;
        }

        public static Book Year(string title)
        {
            return new Book(title);
        }

    }
}
