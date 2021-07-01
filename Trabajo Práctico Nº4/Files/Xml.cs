using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Files
{
    public class Xml<T> : IFiles<T>
    {
        string folder;

        /// <summary>
        /// Builder default
        /// </summary>
        public Xml()
        {
            folder = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, @"\SerializationXml");
        }
        /// <summary>
        /// Saves the data it receives as a parameter in a file
        /// </summary>
        /// <param name="file">File path </param>
        /// <param name="data">Data to save</param>
        /// <returns>True or False if the file was saved well</returns>
        public bool Save(string file, T data)
        {
            try
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                file = folder + file;
                using (XmlTextWriter writer = new XmlTextWriter(file, Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, data);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to save file: {file}", ex);
            }
        }

        /// <summary>
        /// Read saved data from a file
        /// </summary>
        /// <param name="file">File path</param>
        /// <param name="data">Where it records read data</param>
        /// <returns>True or False if the file was read well</returns>
        public bool Read(string file, out T data)
        {
            try
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                file = folder + file;
                using (XmlTextReader reader = new XmlTextReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    data = (T)serializer.Deserialize(reader);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to read file: {file}", ex);
            }
        }
    }
}
