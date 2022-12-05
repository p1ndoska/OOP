using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class KAYDirInfo
    {
        public static void TimeCreation(string path)
        {
            DirectoryInfo Directory = new DirectoryInfo(path);
            Console.WriteLine($"Время создания : {Directory.CreationTime}");
        }

        public static void Parent(string path) {
            DirectoryInfo Directory = new DirectoryInfo(path);
            Console.WriteLine($"Список родительских дерикториев: {Directory.Parent}");
        }

        public static void GetFiles(string path)
        {
            DirectoryInfo Directory = new DirectoryInfo(path);
            Console.WriteLine($"Время создания : {Directory.GetFiles()}");
        }
    }
}
