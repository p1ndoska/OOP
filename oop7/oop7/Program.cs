
using System;
using System.Collections.Generic;
using System.IO;

namespace oop7
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //  Создание коллекций
                CollectionType<int> intCollection = new CollectionType<int>();
                // фукции коллекции
                intCollection.Add(11);
                intCollection.Add(22);
                intCollection.Add(33);
                intCollection.Add(44);
                intCollection = intCollection + 55;
                intCollection = intCollection >> 55;
                intCollection.Show();
                intCollection.Delete(11);
                intCollection.Show();

                CollectionType<string> strCollection = new CollectionType<string>();
                strCollection.Add("qqq");
                strCollection.Add("wwww");
                strCollection.Add("eee");
                strCollection.Show();
                strCollection.Delete("qqq");
                strCollection.Show();

                //исключение
                //strCollection.Add();
                //strCollection.Delete();

                PrintedEdiction ediction1 = new PrintedEdiction("qqq", 2022, 20);
                PrintedEdiction ediction2 = new PrintedEdiction("www", 2011, 20);

                //класс в качестве параметра
                CollectionType <PrintedEdiction> editionList1= new CollectionType<PrintedEdiction>();
                editionList1.Add(ediction1);
                editionList1.Add(ediction2);
                editionList1.Show();

                ////чтение из файла
                CollectionType<int>.WriteToFile(intCollection);
                CollectionType<int>.LoadFromFile();

                CollectionType<string>.WriteToFile(strCollection);
                CollectionType<string>.LoadFromFile();
            }


            // обработка исключений
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Программа завершена.");
                Console.ReadKey();
            }
            Console.ForegroundColor = ConsoleColor.White;



        }
    }
}
