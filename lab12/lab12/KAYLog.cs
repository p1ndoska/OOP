using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class KAYLog

    {
        public static string pathLog = @"D:\2\oop\OOP\lab12\kaylogfile.txt";

        public static void WriteLog(string Изменения)
        {
            if (!File.Exists(pathLog))
            {
                File.Create(pathLog);
            }

            using (StreamWriter file = new StreamWriter(pathLog, true))
            {
                file.Write(DateTime.Now);
                file.WriteLine(" " + Изменения);

            }
        }

        public static void ReadLog()
        {
            if (!File.Exists(pathLog))
            {
                Console.WriteLine("Файла лог нет(((");
                return;
            }
            using (StreamReader file = new StreamReader(pathLog, true))
            {

                file.ReadLine();

            }

        }
    }
}