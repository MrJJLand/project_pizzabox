using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Storing.Repositories
{
    public class FileRepository
    {
        public T ReadFromFile<T>(string path) where T : class
        {
            try
            {
                var reader = new StreamReader(path);
                var xml = new XmlSerializer(typeof(T));

                return xml.Deserialize(reader) as T; //If casting fails, Null. POCOs: Plain Old C# Objects
                //return (List<AStore>)xml.Deserialize(reader); //If casting fails, exception
            }
            catch
            {
                return null;
            }

        }
        public bool WriteToFile<T>(string _path, T stores) where T : class
        {
            try
            {
                var writer = new StreamWriter(_path);
                var xml = new XmlSerializer(typeof(T));

                xml.Serialize(writer, stores);

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}