using lab12;
using System;
using System.IO;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\2\oop\OOP\lab12\"
            + "kaylogfile" + ".txt";

            if (!File.Exists(path)) File.Create(path);

            KAYDiskInfo.FreeMemory();
            KAYDiskInfo.DriveFormat();
            KAYDiskInfo.AllInfo();

            Console.WriteLine("_________________________________________");

            KAYFileInfo.FileInfo(@"D:\2\oop\OOP\lab12\kaylogfile.txt");
            KAYFileInfo.GetTimeCreation(@"D:\2\oop\OOP\lab12\kaylogfile.txt");

            Console.WriteLine("_________________________________________");

            KAYDirInfo.TimeCreation(@"D:\2\oop\OOP\lab12");
            KAYDirInfo.Parent(@"D:\2\oop\OOP\lab12");
            KAYDirInfo.GetFiles(@"D:\2\oop\OOP\lab12");
            KAYDirInfo.GetDirCount(@"D:\2\oop\OOP\lab12");
            KAYDirInfo.GetFilesCount(@"D:\2\oop\OOP\lab12");

        }
    }
}