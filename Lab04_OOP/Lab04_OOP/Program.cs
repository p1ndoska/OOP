﻿using System;

namespace Lab04_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            publishingHouse Object = new publishingHouse("ACT", "проспект Жукова, 34");
            Console.WriteLine(Object);

            book Object1 = new book("И. А. Бродский", "неизвестно", "мягкая обложка", 224, "Набережная неисцелимых", 9, "Лениздат", "проспект Победителей, 3","биография");
            Console.WriteLine(Object1);

            textbook Object2 = new textbook("твердая", "физика", 11, 500, "Учебник по физике", 13, "Аверсэв", "Олешевва 1","естественные науки");
            Console.WriteLine(Object2);

            magazine Object3 = new magazine("раз в год", "наука и техника", 300, "Собака.ru", 23, "Редакция", "проспект Независимости, 10","искусство");
            Console.WriteLine(Object3);

            //getInfo();
          
        }
    }
}
