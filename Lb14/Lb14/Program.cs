using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml;
using System.Xml.Linq;

namespace Lb14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table("Brown", 4);
            Console.WriteLine("Задание 1");
            Console.WriteLine("\nBinary");
            // создаем объект BinaryFormatter
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(@"D:/14-я/table.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, table);

                Console.WriteLine("Объект сериализован");
            }
            // десериализация из файла people.dat
            using (FileStream fs = new FileStream(@"D:/14-я/table.dat", FileMode.Open))
            {
                Table newCircle = (Table)binaryFormatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Цвет: {newCircle.Color}, Длинна: {newCircle.length}");
            }

            //работа с json файлом
            Console.WriteLine("\nJson");
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Table));
            using (FileStream fs = new FileStream(@"D:/14-я/table.json", FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(fs, table);
                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream(@"D:/14-я/table.json", FileMode.Open))
            {
                Table newCircle = (Table)jsonSerializer.ReadObject(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Цвет: {newCircle.Color}, Длинна: {newCircle.length}");
            }

            //работа с xml файлом
            Console.WriteLine("\nXML");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Table));
            using (FileStream fs = new FileStream(@"D:/14-я/table.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, table);
                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream(@"D:/14-я/table.xml", FileMode.Open))
            {
                Table newCircle = (Table)xmlSerializer.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Цвет: {newCircle.Color}, Длинна: {newCircle.length}");
            }

            //работа с soap файлом
            Console.WriteLine("\nSoap");
            SoapFormatter soapFormatter = new SoapFormatter();
            using (FileStream fs = new FileStream(@"D:/14-я/table.soap", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(fs, table);
                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream(@"D:/14-я/table.soap", FileMode.Open))
            {
                Table newCircle = (Table)soapFormatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Цвет: {newCircle.Color}, Длинна: {newCircle.length}");
            }

            Console.WriteLine("\nЗадание 2");
            XmlSerializer serializer = new XmlSerializer(typeof(Table[]));
            Table table1 = new Table("white", 3);
            Table table2 = new Table("black", 4);
            Table[] tables = new Table[] { table1, table2 };
            using (FileStream fs = new FileStream(@"D:/14-я/tablemas.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, tables);
                Console.WriteLine("Массив объект сериализован");
            }
            using (FileStream fs = new FileStream(@"D:/14-я/tablemas.xml", FileMode.Open))
            {
                Table[] newTables = (Table[])serializer.Deserialize(fs);
                Console.WriteLine("Массив объект десериализован");
                foreach (Table c in newTables)
                {
                    Console.WriteLine($"Цвет: {c.Color}, Длинна: {c.length}");
                }
            }

            Console.WriteLine("\nЗадание 3");
            XmlDocument xDoc = new XmlDocument();
            //загрузка xml документа
            xDoc.Load(@"D:/14-я/tablemas2.xml");
            //получение корневого элемента
            XmlElement xRoot = xDoc.DocumentElement;

            Console.WriteLine("выбор всех дочерних узлов");
            XmlNodeList childnodes = xRoot.SelectNodes("*");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.OuterXml);

            Console.WriteLine("выбор дочернего узла по имени");
            XmlNode childnode = xRoot.SelectSingleNode("Table[@name='table2']");
            if (childnode != null)
                Console.WriteLine(childnode.OuterXml);

            Console.WriteLine("выбор по цвету");
            XmlNodeList childnodes2 = xRoot.SelectNodes("//Table//Color");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.InnerText);

            Console.WriteLine("\nЗадание 4");

            XDocument xdoc = new XDocument(new XElement("tables",
                                    new XElement("table",
                                            new XAttribute("name", "table1"),
                                            new XElement("color", "green"),
                                            new XElement("length", "23")),
                                    new XElement("table",
                                            new XAttribute("name", "table2"),
                                            new XElement("color", "blue"),
                                            new XElement("length", "44"))));
            xdoc.Save("D://14-я//tables4.xml");
            Console.WriteLine("Документ создан");

            XDocument xdoc1 = XDocument.Load("D://14-я//tables4.xml");
            var items = from xe in xdoc.Element("tables").Elements("table")
                        where xe.Attribute("name").Value == "table2"
                        select new Table
                        {
                            Color = xe.Element("color").Value,
                            length = Convert.ToInt32(xe.Element("length").Value)
                        };

            foreach (var item in items)
                Console.WriteLine($"{item.Color} - {item.length}");

        }
    }

}
