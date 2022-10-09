using System;

namespace Lab02
{

    class Program
    {
        static void Main()
        {
            Book Object1 = new Book("Полторы комнаты", "И. А. Бродский");
            Object1.Print();
            Book Object2 = new Book();
            Object2.Print();
            Book Object3 = new Book("Меньше единицы", 44, 432);
            Object3.Print();
            Book Object4 = Book.Year("1984");
            Object4.Print();
            Book.getInfo();
            Console.WriteLine($"Результат сравнения объектов: {Object1.Equals(Object4)}");
            Console.WriteLine(Object1.ToString());
            Console.WriteLine("id: "+Object3.GetHashCode());
            Console.WriteLine($"Цена книги: {Object3.Price}");
            Console.WriteLine("Тип объекта: "+Object3.GetType());
        }
    }
}
