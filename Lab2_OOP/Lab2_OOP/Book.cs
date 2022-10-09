﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    partial class Book
    {
        private readonly int id;

        private string title;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        private string authors;

        public string Authors
        {
            get
            {
                return authors;
            }
            set
            {
                authors = value;
            }
        }

        static string publishingHouse;

        private int theYearOfPublishing;

        public int TheYearOfPublishing
        {
            get
            {
                return theYearOfPublishing;
            }
            set
            {
                theYearOfPublishing = value;
            }
        }

        private int numberOfPage;

        public int NumberOfPage
        {
            get
            {
                return numberOfPage;
            }
            set
            {
                numberOfPage = value;
            }
        }

        private int price;

        public int Price
        {
            get
            {
                return price;
            }
            protected set
            {
                if (price < 0)
                {
                    Console.WriteLine("таких тут нет(");
                }
                else
                {
                    price = value;
                }
            }
        }

        static string bindingType;

        private const int HASH = 12 + 329 * 15539;

        public static int numberOfBooks = 0;

        //public Book(string title, string authors)
        //{
        //    this.title = title;
        //    numberOfPage = 200;
        //    price = 10;
        //    this.authors = authors;
        //    id = numberOfPage + HASH;
        //    numberOfBooks++;
        //}
        ////конструктор без параметром
        //public Book()
        //{
        //    title = "Неизвестно";
        //    authors = "Неизвестно";
        //    numberOfPage = 0;
        //    id = numberOfPage + HASH;
        //    numberOfBooks++;
        //}
        ////конструктор с параметром по умолчанию
        //public Book(string title, int price, int numberOfPage, string authors = "И. А. Бродский")
        //{
        //    this.title = title;
        //    this.price = price;
        //    this.numberOfPage = numberOfPage;
        //    this.authors = authors;
        //    id = numberOfPage + HASH;
        //    numberOfBooks++;
        //}
        ////статический конструктор
        //static Book()
        //{
        //    publishingHouse = "Лениздат";
        //    bindingType = "неизвестно";
        //    numberOfBooks++;
        //}

        ////приватный конструктор
        //private Book(string title)
        //{
        //    this.title = title;
        //    theYearOfPublishing = 1984;
        //    id = numberOfPage + HASH;
        //    numberOfBooks++;
        //}

        //public static Book Year(string title)
        //{
        //    return new Book(title);
        //}
        public void Print()
        {
            Console.WriteLine($"Название: {title}\nАвтор: {authors}\nЦена: {price}\nИздательство: {publishingHouse}\nГод публикации: {theYearOfPublishing}\nКоличество страниц: {numberOfPage}\nтип переплета: {bindingType}\nid: {id}\n\n");
        }

        public static void getInfo()
        {
            Console.WriteLine($"Всего книг: {numberOfBooks}");
        }

        public override bool Equals(object obj)
        {
            Book temp = obj as Book;
            return temp.price == this.price;
        }

        public override int GetHashCode()
        {
            return id;
        }

        public override string ToString()
        {
            return $"Название: {title}\nАвтор: {authors}\nЦена: {price}\nИздательство: {publishingHouse}\nГод публикации: {theYearOfPublishing}\nКоличество страниц: {numberOfPage}\nтип переплета: {bindingType}\nid: {id}\n\n";
        }
    }
}
