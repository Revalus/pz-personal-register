using System;
using System.IO;
using System.Xml.Serialization;
using PersonalRegister.Data;

namespace PersonalRegister
{
    class Program
    {
        static void Main(string[] args)
        {   
            string serializeFile = "serializator.xml";
            PeopleRegister peopleRegister = null;
            XmlSerializer serializer = new XmlSerializer(typeof(PeopleRegister));
            try
            {
                FileStream serializedFileStream = new FileStream(serializeFile, FileMode.Open);
                peopleRegister = (PeopleRegister) serializer.Deserialize(serializedFileStream);
            } catch(System.IO.FileNotFoundException) {
                peopleRegister = new PeopleRegister();
            }
            
            peopleRegister = new UserMenu(peopleRegister).Run();
            TextWriter writer = new StreamWriter(serializeFile);
            serializer.Serialize(writer, peopleRegister);
            writer.Close();
        }
    }
}