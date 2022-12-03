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
        }
    }
}