using System;

namespace Lab02
{

    class Program
    {
        static void Foo1(ref int a)
        {
            a = 1;
        }

        static void Foo2(out int a)
        {
            a = 1;
        }
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
            Book[] ArrayObj = { Object1, Object2, Object3, Object4 };

            Console.WriteLine("\nКниги выпущенные после заданного года: ");
            for(int i =0; i < 4; i++)
            {
                if (ArrayObj[i].TheYearOfPublishing > 2000)
                {
                    Console.WriteLine(ArrayObj[i].ToString());
                }
            }
            Console.WriteLine("Список книг автора: ");
            for (int i = 0; i < 4; i++)
            {
                if (ArrayObj[i].Authors == "И. А. Бродский")
                {
                    Console.WriteLine(ArrayObj[i].ToString());
                }
            }

            var AnonimBook = new { title = "Набережная неисцелимых", price = 10000 };
            Console.WriteLine(AnonimBook.title + " Цена: " + AnonimBook.price);
            int VarA = 2;
            Foo1(ref VarA);

            Foo2(out int VarB);
            Console.WriteLine("Результат работы с ref:" + VarA);
            Console.WriteLine("Результат работы с out:" + VarB);


        }
    }
}
