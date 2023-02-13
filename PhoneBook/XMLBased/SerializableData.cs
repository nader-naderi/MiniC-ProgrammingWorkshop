using System;
using System.IO;
using System.Xml.Serialization;


namespace PhoneBook
{
    public class SerializableData
    {
        public void Save(string filename)
        {
            string tempFilename;
            tempFilename = filename + ".tmp";

            FileInfo tempFileInfo = new FileInfo(tempFilename);

            if (tempFileInfo.Exists)
            {
                tempFileInfo.Delete();
            }

            FileStream stream = new FileStream(tempFilename, FileMode.Create);

            Save(stream);

            stream.Close();

            // Remove the existing data file.
            tempFileInfo.CopyTo(filename, true);
            tempFileInfo.Delete();
        }

        public void Save(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(GetType());
            serializer.Serialize(stream, this);
        }

        public static object Load(string filename, Type newType)
        {
            FileInfo fileInfo = new FileInfo(filename);
            
            if (!fileInfo.Exists)
                return Activator.CreateInstance(newType);

            FileStream stream = new FileStream(filename, FileMode.Open);
            object newObject = Load(stream, newType);
            stream.Close();
            return newObject;
        }

        public static object Load(Stream stream, Type newType)
        {
            XmlSerializer serializer = new XmlSerializer(newType);
            object newObject = serializer.Deserialize(stream);
            return newObject;
        }

    }
}
