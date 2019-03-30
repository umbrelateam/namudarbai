using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal bowser = new Animal("Bowser", 40, 26);

            // Serialize the object data to a file
            Stream stream = File.Open("AnimalData.dat", FileMode.Create); //Байтовый поток.В классе Stream определен набор членов, которые обеспечивают поддержку синхронного и асинхронного взаимодействия с хранилищем.
            BinaryFormatter bf = new BinaryFormatter();

            // Send the object data to the file
            bf.Serialize(stream, bowser);
            stream.Close();

            // Delete the bowser data
            bowser = null;

            // Read object data from the file
            stream = File.Open("AnimalData.dat", FileMode.Open);
            bf = new BinaryFormatter();

            bowser = (Animal)bf.Deserialize(stream);
            stream.Close();

            Console.WriteLine(bowser.ToString());

            // Change bowser to show changes were made
            bowser.Weight = 50;

            // XmlSerializer writes object data as XML
            XmlSerializer serializer = new XmlSerializer(typeof(Animal));
            using (StreamWriter tw = new StreamWriter("bowser.xml"))
            {
                serializer.Serialize(tw, bowser);
            }

            // Delete bowser data
            bowser = null;

            // Deserialize from XML to the object
            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));
            StreamReader reader = new StreamReader("bowser.xml");
            object obj = deserializer.Deserialize(reader);
            bowser = (Animal)obj;
            reader.Close();

            Console.WriteLine(bowser.ToString());

            // Save a collection of Animals
            List<Animal> theAnimals = new List<Animal>
            {
                new Animal("Elephant", 65, 29),
                new Animal("Lion", 55, 28),
                new Animal("Hippopotamus", 31, 23)
            };

            using (Stream fs = new FileStream("animals.xml",FileMode.Create, FileAccess.Write, FileShare.None)) //Класс FileStream представляет возможности по считыванию из файла и записи в файл. Он позволяет работать как с текстовыми файлами, так и с бинарными.
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
                serializer2.Serialize(fs, theAnimals);
            }

            // Delete list data
            theAnimals = null;

            // Read data from XML
            XmlSerializer deserializer2 = new XmlSerializer(typeof(List<Animal>));

            using (FileStream fs2 = File.OpenRead("animals.xml"))
            {
                theAnimals = (List<Animal>)deserializer2.Deserialize(fs2);
            }


            foreach (Animal a in theAnimals)
            {
                Console.WriteLine(a.ToString());
            }

            Console.ReadLine();
        }
    }
}
