using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization;

using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Linq;
using System.Xml;
using System.Linq;

namespace Lab13
{
    [Serializable]
    public class Lol
    {
        public string Color;
        [NonSerialized]
        public string SubColor;
        public Lol(string Color)
        {
            this.Color = Color;
            
            SubColor = Color + "aaa";
        }
        public Lol() => this.Color = "yellow";
    }


    class Program
    {
         public static void SerialDeserial(Lol lol, ISerDeser obj)
        {
            obj.Serialize(lol);
        }
        static void Main(string[] args)
        {
            Lol lol2 = new Lol("pink");
            Lol lol = new Lol("red");
            Lol[] Lols = { lol, lol2 };
            //Binary
            SerialDeserial(lol, new Bin());
            //Soap
            SerialDeserial(lol2, new Soap());
            //XML
            SerialDeserial(lol, new Xml());
            //JSON
            SerialDeserial(lol2, new Json());
            //z2
            JsonArr.Serialize(Lols);

            XmlDocument newDocument = new XmlDocument();
            newDocument.Load("lol.xml");
            XmlElement? root = newDocument.DocumentElement;
            XmlNodeList? nodes = root?.SelectNodes("*");
            Console.WriteLine("\nВсе узлы в lol.XML:");
            if (!(nodes is null))
            {
                foreach (XmlNode node in nodes)
                {
                    Console.WriteLine(node.Name);
                }
            }
            else
            {
                Console.WriteLine("Узлы пустые.");
            }

            Console.WriteLine("\nЧто находится в теге Color:");
            XmlNodeList? nameOfThePrintPublicationNodes = root?.SelectNodes("Color");
            if (!(nameOfThePrintPublicationNodes is null))
            {
                foreach (XmlNode node in nameOfThePrintPublicationNodes)
                {
                    Console.WriteLine(node.InnerText);
                }
            }
            else
            {
                Console.WriteLine("Узлы пустые.");
            }

            //4 задание
            XDocument xDocument = new XDocument();
            XElement rootElement = new XElement("Cars");

            //Первая машина
            XElement honda = new XElement("Honda");
            XElement nameOfHonda = new XElement("Name", "Civic");
            XElement engineCapacityOfHonda = new XElement("Engine_Capacity", 1.6);
            honda.Add(nameOfHonda);
            honda.Add(engineCapacityOfHonda);

            //Вторая машина
            XElement toyota = new XElement("Toyota");
            XElement nameOfToyota = new XElement("Name", "Corolla");
            XElement engineCapacityOfToyota = new XElement("Engine_Capacity", 1.6);
            toyota.Add(nameOfToyota);
            toyota.Add(engineCapacityOfToyota);

            //Третья машина
            XElement secondToyota = new XElement("Toyota");
            XElement nameOfSecondToyota = new XElement("Name", "Supra");
            XElement engineCapacityOfSecondToyota = new XElement("Engine_Capacity", 2.5);
            secondToyota.Add(nameOfSecondToyota);
            secondToyota.Add(engineCapacityOfSecondToyota);

            rootElement.Add(honda);
            rootElement.Add(toyota);
            rootElement.Add(secondToyota);

            xDocument.Add(rootElement);
            xDocument.Save("Cars.xml");

            //Linq To XML
            XDocument documentForQueries = XDocument.Load("Cars.xml");

            Console.WriteLine("\nВыборка только по Тойотам:");
            var onlyToyotas = documentForQueries.Element("Cars")!.Elements("Toyota").Select(p => new
            {
                name = p.Element("Name")?.Value,
                engineCapacity = p.Element("Engine_Capacity")?.Value
            }
            );

            foreach (var car in onlyToyotas)
            {
                Console.WriteLine($"Название модели: {car.name}\nОбъём двигателя: {car.engineCapacity}");
            }

            Console.WriteLine("\nТойоты только с двигателем объёмом 1.6л:");
            var engineCapacityQuery = documentForQueries.Element("Cars")!.Elements("Toyota")
                .Where(p => p.Element("Engine_Capacity")!.Value == "1.6").Select(p => new
                {
                    name = p.Element("Name")?.Value,
                    engineCapacity = p.Element("Engine_Capacity")?.Value
                });
            foreach (var car in engineCapacityQuery)
            {
                Console.WriteLine($"Название модели: {car.name}\nОбъём двигателя: {car.engineCapacity}");
            }





        }
    }
}
