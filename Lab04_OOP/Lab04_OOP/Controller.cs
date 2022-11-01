using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class Controller
    {
        public void PrintTitle(Container ct, int year) 
        {

            foreach (PrintedEdition item in ct.list)
            {
                if (item.GetType().Name == "Book"){
                    if (item.theYearOfPublishing > year)
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
