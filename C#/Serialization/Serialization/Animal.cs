using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    [Serializable] //Сериализация - процесс преобразования объекта в поток байтов для сохранения или передачи в память.
    public class Animal     :ISerializable
    {
        public string Name { get; set; } //Свойства. Обеспечивают простой доступ к полям класса, узнать их значение или выполнить их установку.
        public double Weight { get; set; }
        public double Height { get; set; }

        public Animal() { }

        public Animal(string name = "No Name",double weight = 0,double height = 0)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return string.Format("{0} weighs {1} lbs and is {2} inches tall",
                Name, Weight, Height);
        }

        // Serialization function (Stores Object Data in File)
        // SerializationInfo Stores all the data needed to serialize or deserialize an object
        // StreamingContext Describes the source and destination of a given serialized stream
        // but we aren't using it here
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            info.AddValue("Name", Name);
            info.AddValue("Weight", Weight);
            info.AddValue("Height", Height);
        }

        // The deserialize function (Removes Object Data from File)
        public Animal(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the properties
            Name = (string)info.GetValue("Name", typeof(string));
            Weight = (double)info.GetValue("Weight", typeof(double));
            Height = (double)info.GetValue("Height", typeof(double));
        }
    }
}
