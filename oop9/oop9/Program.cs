using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace oop9
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer1 = new Computer("MSI Leopard GL65", "Red", 2700);
            Computer computer2 = new Computer("ASUS TUF Gaming F15", "Purple", 2500);
            Computer computer3 = new Computer("Lenova IdeaPad", "Blue", 2000);
            Computer computer4 = new Computer("qqq", "www", 3000);

            MyCollection<Computer> computers = new MyCollection<Computer>();
            computers.Add(computer1);
            computers.Add(computer2);
            computers.Add(computer3);
            computers.Add(computer4);
            computers.Show();

            computers.Remove(computer4);
            computers.Show();


            //Computer found = computers.Find(item => item.Price == 1);
            Console.WriteLine("====================================");
            MyCollection<int> intColl = new MyCollection<int>();
            for (int i = 1; i < 10; i++)
                intColl.Add(i);
         
            intColl.Show();

            // удаляем из HashSetа значения 
            for (int i = 2; i < 6; i++)
                intColl.Remove(i);
            intColl.Show();

            //List<int> intList = new List<int>();
            //for (int i = 1; i < 10; i++)
            //    intList.Add(i);

            List<Computer> compList = new List<Computer>();
            compList.Add(computer1);
            compList.Add(computer2);
            compList.Add(computer3);
            compList.Add(computer4);

            foreach (var i in compList)
            {
                Console.WriteLine(i);
            }

            Computer found = compList.Find(item => item.Price == 2500);
            Console.WriteLine(found);

            ObservableCollection<Computer> ObsCol = new ObservableCollection<Computer>();
            Console.WriteLine("______________________________________");
            ObsCol.CollectionChanged += ObsCol_CollectionChanged;

            ObsCol.Add(computer1);
            ObsCol.Add(computer2);
            ObsCol.Remove(computer2);
        }

        private static void ObsCol_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Объект изменён: "+ e.Action);

      }
    }

}
