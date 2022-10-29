using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class library
    {
        public int amount = 0;

        public List<Equipment> list = new List<Equipment>();
        internal int service_life;

        public library()             /// конструктор без параметров
        {
        }
        public library(Computer firstItem, PrintingDevice secondItem, Scanner thirdItem, Tablet fourthItem, Computer fifthItem)
        {
        }

        public void Add(Equipment obj)      /// метод для добавление объектов в список
        {
            list.Add(obj);
            amount++;
        }

        public void Delete(Equipment obj)   /// метод для удаления объектов из списка
        {
            if (amount == 0)
            {
                throw new NullReferenceException("Количество объектов не может быть равно 0!");
            }
            list.Remove(obj);
            amount--;
        }

        public void Printing()              /// метод для вывода списка на консоль
        {
            foreach (var i in list)
                Console.WriteLine(i.ToString());
        }
    }
}
