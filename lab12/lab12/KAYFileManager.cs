using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace Lab12
{
    class KAYFileManager
    {

        public static void Task1(string DISK, string path)
        {


            Directory.CreateDirectory(path); //создали директорий



            DriveInfo drive = new DriveInfo(DISK);
            var Files = drive.RootDirectory.GetFiles();
            var Dir = drive.RootDirectory.GetDirectories();
            string Newpath = Path.Combine(path, @"\KAYdirinfo.txt");
            using (StreamWriter file = new StreamWriter(Newpath))
            {
                file.WriteLine("______________________________________________");
                file.WriteLine("Список дирректориев");

                foreach (var i in Dir)
                {
                    file.WriteLine(i);
                }
                file.WriteLine("______________________________________________");
                file.WriteLine("Список файлов");
                foreach (var i in Files)
                {
                    file.WriteLine(i);
                }
            }
            FileInfo filenew = new FileInfo(Newpath);
            if (!File.Exists(path + @"\KAYdirinfoCOPY.txt"))
            {
                filenew.CopyTo(path + @"\KAYdirinfoCOPY.txt");
            }
            filenew.Delete();
        }

        public static void Task2(string path)
        {
            Directory.CreateDirectory(path); //создали директорий
            DirectoryInfo buff = new DirectoryInfo(@"D:\2\oop\OOP\lab12\KAYbuff");
            var files = buff.GetFiles();
            foreach (var f in files)
            {

                if (f.Extension == ".txt" && !File.Exists(path + $@"\{f.Name}"))
                {

                    File.Copy(f.FullName, path + $@"\{f.Name}");
                }
            }
            if (!Directory.Exists(@"D:\2\oop\OOP\lab12\KAYInspect\KAYFiles") && Directory.Exists(path))
            {
                Directory.Move(path, @"D:\2\oop\OOP\lab12\KAYInspect\KAYFiles");
            }
        }

        public static void Task3()
        {
            if (!File.Exists(@"D:\2\oop\OOP\lab12\KAYInspect\KAYFiles.zip"))
            {
                ZipFile.CreateFromDirectory(@"D:\2\oop\OOP\lab12\KAYInspect\KAYFiles", @"D:\2\oop\OOP\lab12\KAYInspect\KAYFiles.zip");
            }
            if (!Directory.Exists(@"D:\2\oop\OOP\lab12\KAYInspect\KAYFilesEXTR"))
            {
                ZipFile.ExtractToDirectory(@"D:\2\oop\OOP\lab12\KAYInspect\KAYFiles.zip", @"D:\2\oop\OOP\lab12\KAYInspect\KAYFilesEXTR");
            }
        }
    }

}

