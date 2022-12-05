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

        //свободное место на диске
        static public void FreeMemory()
        {
            Console.WriteLine($"Свободное место на диске {Disk.Name}: {(float)Disk.TotalFreeSpace / 1024 / 1024 / 1024}");
        }
        //инф о файловой системе
        static public void DriveFormat()
        {
            Console.WriteLine($"Имя файловой системы: {Disk.DriveFormat}");
        }

        //имя, объем, доступный объем, метка тома
        static public void AllInfo()
        {
            Console.WriteLine("_________________________________________");
            var allDrives = DriveInfo.GetDrives();
            foreach (var d in allDrives)
            {
                Console.WriteLine("Drive name: {0}", d.Name);//
                if (!d.IsReady) continue;
                Console.WriteLine("Volume Label: {0}", d.VolumeLabel);//
                Console.WriteLine("To" +
                    "tal size: {0}", d.TotalSize);//
                Console.WriteLine("Free size: {0}", d.TotalFreeSpace);//
            }
        }
    }
}
