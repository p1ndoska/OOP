using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop14
{
    class Program
    {
        static void Main(string[] args)
        {
            //First();
            //Second();///////////
            //Third();

            //Fourth();
            //Fifth();
        }


        private static void First()
        {
            var allProcesses = Process.GetProcesses();
            Console.WriteLine("Информация о процессах:");
            Console.Write("{0,-10}", "ID:");
            Console.Write("{0,-70}", "Process Name:");
            Console.Write("{0,-20}", "Priority:");
            Console.Write("{0,-10}", "Memory:\n");

            foreach (Process process in allProcesses)
            {
                Console.Write("{0,-10}", $"{process.Id}");
                Console.Write("{0,-70}", $"{process.ProcessName}");
                Console.Write("{0,-20}", $"{process.BasePriority}");
                Console.Write("{0,-10}", $"{process.WorkingSet64}");

                Console.WriteLine();
            }

        }
        private static void Second()
        {

            AppDomain domain = AppDomain.CurrentDomain;    // текущий домен с процессами
            Console.WriteLine("\n\n\n\nТекущий домен:         " + domain.FriendlyName);
            Console.WriteLine("Базовый каталог:       " + domain.BaseDirectory);
            Console.WriteLine("Детали конфигурации:   " + domain.SetupInformation);
            Console.WriteLine("Все сборки в домене:\n");
            foreach (Assembly ass in domain.GetAssemblies())
                Console.WriteLine(ass.GetName().Name);

        }

        private static void Third()
        {

            Thread NumbersThread = new Thread(new ParameterizedThreadStart(WriteNums));   // создаем новый поток
            Console.Write("Задайте число: "); int numb = Convert.ToInt32(Console.ReadLine());
            NumbersThread.Start(numb);  // запускаем его

            Thread.Sleep(2000);   // приостанавливает выполнение потока, в котором он был вызван

            Console.WriteLine("\n--------------------");
            Console.WriteLine("Приоритет:   " + NumbersThread.Priority);
            Thread.Sleep(100);
            Console.WriteLine("Имя потока:  " + NumbersThread.Name);
            Thread.Sleep(100);
            Console.WriteLine("ID потока:   " + NumbersThread.ManagedThreadId);
            Console.WriteLine("---------------------");
            Thread.Sleep(1000);

            //Thread.Sleep(2000);  // приостанавливает выполнение потока, в котором он был вызван

            void WriteNums(object number)
            {
                int num = (int)number;

                using (StreamWriter sw = new StreamWriter(@"D:\2\oop\OOP\oop14\numbers.txt", false, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < num; i++)
                    {
                        sw.WriteLine(i);
                        Console.WriteLine(i);
                        Thread.Sleep(500);
                    }
                }
            }

        }


    }
}