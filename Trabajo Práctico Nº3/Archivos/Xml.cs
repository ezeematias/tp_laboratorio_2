using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Files
{
    public class Xml<T> : IFiles<T> 
    {
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
                string fileName = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, file);
                using (XmlTextWriter writer = new XmlTextWriter(fileName, Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, data);
                    return true;
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"Failed to save file: {file}");
            }
            catch (Exception ex)
            {
                throw ex;
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
                string fileName = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, file);
                using (XmlTextReader reader = new XmlTextReader(fileName))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    data = (T)serializer.Deserialize(reader);
                    return true;
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"Failed to read file: {file}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
