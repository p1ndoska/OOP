
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class KAYFileInfo
    {   
        static public void FileInfo(string path)
        {
            FileInfo file = new FileInfo (path);
            Console.WriteLine($"Полный путь: {file.DirectoryName}");
            Console.WriteLine($"Размер файла: {file.Length}");
            Console.WriteLine($"Расширение файла: {file.Extension}");
            Console.WriteLine($"Имя: {file.Name}");
        }

        public static void GetTimeCreation(string path)
        {
            FileInfo file = new FileInfo(path);
            Console.WriteLine($"Время создания : {file.CreationTime}");
        }


    }
}
