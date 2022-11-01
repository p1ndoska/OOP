using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class Controller
    {
        public void Sort(Container ct) //Провести сортировку цветов в букете на основе любого параметра
        {
            ct.list.Sort();
        }

        public void PrintTitle(Container ct, int year) //Найти цветок в букете, соответствующий заданному цвету.
        {

            foreach (PrintedEdition item in ct.list)
            {
                if (item.GetType().Name == "Book"){
                    
                        Console.WriteLine(item.title);
                }
                
                
            }
        }
        public void Sum(Container ct)
        {
            int sum = 0;

            foreach (object item in ct.list)
            {
                if (item.GetType().Name == "Textbook")
                {
                    sum++;
                }
            }

            Console.WriteLine($"Количество учебников = {sum}");
        }

        public void TotalCost(Container ct)
        {
            double sum = 0;

            foreach (object item in ct.list)
            {
               
                if (item.GetType().BaseType.Name == "PrintedEdition")
                {
                    sum += ((PrintedEdition)item).price;
                }
            }

            Console.WriteLine($"Стоимость книг в библиотеке: = {sum}");
        }
    }
}
