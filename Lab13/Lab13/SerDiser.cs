using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Serialization;

namespace Lab13
{
    class Bin : ISerDeser
    {
        public void Serialize(Lol obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("points.dat", FileMode.OpenOrCreate))
            {
#pragma warning disable SYSLIB0011 // Тип или член устарел
                formatter.Serialize(fs, obj);
            }
            using (FileStream fs = new FileStream("points.dat", FileMode.OpenOrCreate))
            {
                Lol newLol = (Lol)formatter.Deserialize(fs);
                Console.WriteLine(newLol.Color + newLol.SubColor);
            }
        }
#pragma warning restore SYSLIB0011 // Тип или член устарел


    }
    class Xml : ISerDeser
    {
        public void Serialize(Lol obj)
        {
            XmlSerializer xSer = new XmlSerializer(typeof(Lol));
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("lol.xml", FileMode.OpenOrCreate))
            {
                xSer.Serialize(fs, obj);
            }
            // десериализация
            using (FileStream fs = new FileStream("lol.xml", FileMode.OpenOrCreate))
            {
                Lol newP = xSer.Deserialize(fs) as Lol;
                Console.WriteLine(newP.Color);
            }
        }
    }
    class Json : ISerDeser
    {
        public void Serialize(Lol obj)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Lol));
            using (FileStream fs = new FileStream("lols.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, obj);
            }
            using (FileStream fs = new FileStream("lols.json", FileMode.OpenOrCreate))
            {
                Lol lols = (Lol)jsonFormatter.ReadObject(fs);
                Console.WriteLine(lols.Color);
            }
        }
    }

    class JsonArr
    {
        public static void Serialize(Lol [] Arr)
        {
            DataContractJsonSerializer jsonFormatter =new DataContractJsonSerializer(typeof(Lol []));
            using (FileStream fs = new FileStream("programmers.json",
            FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, Arr);
            }
            using (FileStream fs = new FileStream("programmers.json",
            FileMode.OpenOrCreate))
            {
                Lol[] newlols =
              (Lol[])jsonFormatter.ReadObject(fs);
                foreach(var i in newlols)
                {
                    Console.Write(i.Color+" ");
                }
            }

        }
    }

    class Soap : ISerDeser
    {
        public void Serialize(Lol obj)
        {
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream fStream = new FileStream("SoapData.dat",
            FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                soapFormatter.Serialize(fStream, obj);
            }
            using (Stream fStream = new FileStream("SoapData.dat",
            FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                Lol newL = (Lol)soapFormatter.Deserialize(fStream);
                Console.WriteLine(newL.Color);
            }
        }
    }
}
