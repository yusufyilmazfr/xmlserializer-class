using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TodoListApp
{
    public class MyXmlSerializer
    {
        public void Serialize(string path, Object obj)
        {
            System.Xml.Serialization.XmlSerializer serialize = new System.Xml.Serialization.XmlSerializer(obj.GetType());
            XmlWriter Writer = XmlWriter.Create(path);
            serialize.Serialize(Writer, obj);
            Writer.Close();
            Writer.Dispose();
        }
        public object DeSerialize(string path, Type type)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(type);
            XmlReader reader = XmlReader.Create(path);
            object obj = serializer.Deserialize(reader);
            reader.Close();
            reader.Dispose();
            return obj;
        }
        public void Serialize<T>(string path, T obj)
        {
            System.Xml.Serialization.XmlSerializer serialize = new System.Xml.Serialization.XmlSerializer(typeof(T));
            XmlWriter Writer = XmlWriter.Create(path);
            serialize.Serialize(Writer, obj);
            Writer.Close();
            Writer.Dispose();
        }
        public T DeSerialize<T>(string path)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            XmlReader reader = XmlReader.Create(path);
            object obj = serializer.Deserialize(reader);
            reader.Close();
            reader.Dispose();
            return (T)obj;
        }
    }
}
