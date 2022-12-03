using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class KAYDiskInfo
    {
        static DriveInfo Disk = new DriveInfo("D");

        static public void FreeMemory()
        {
            Console.WriteLine($"Свободное место на диске {Disk.Name}: {(float)Disk.TotalFreeSpace / 1024 / 1024 / 1024}");
        }

        static public void DriveFormat()
        {
            Console.WriteLine($"Имя файловой системы: {Disk.DriveFormat}");
        }
        static public void AllInfo()
        {
            Console.WriteLine("______________________________________________");
            var allDrives = DriveInfo.GetDrives();
            foreach (var d in allDrives)
            {
                Console.WriteLine("Drive name: {0}", d.Name);//
                if (!d.IsReady) continue;
                Console.WriteLine("Volume Label: {0}", d.VolumeLabel);//
                Console.WriteLine("Total size: {0}", d.TotalSize);//
                Console.WriteLine("Free size: {0}", d.TotalFreeSpace);//
            }
        }
    }
}
