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
            DirectoryInfo directory = new DirectoryInfo(path);
            Console.WriteLine("Список родительских директориев");
            var buff = directory;
            while (directory.Root.Name != buff.Name)
            {
                Console.WriteLine(buff.Parent);
                buff = buff.Parent;
            }
        }

        public static void GetDirCount(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            Console.WriteLine($"Количество поддиректориев: {directory.GetDirectories().Length}");
        }

        public static void GetFilesCount(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            Console.WriteLine($"Количество файлов: {directory.GetFiles().Length}");
        }
    }
}
