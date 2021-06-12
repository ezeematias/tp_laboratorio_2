using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    public class Text : IFiles<string>
    {
        /// <summary>
        /// Saves the data it receives as a parameter in a file
        /// </summary>
        /// <param name="file">File path </param>
        /// <param name="data">Data to save</param>
        /// <returns>True or False if the file was saved well</returns>
        public bool Save(string file, string data)
        {
            try
            {
                string fileName = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, file);
                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    sw.Write(data);
                    return true;
                }
            }
            catch (Exception)
            {
                throw new Exception($"Failed to save file: {file}");
            }
        }

        /// <summary>
        /// Read saved data from a file
        /// </summary>
        /// <param name="file">File path</param>
        /// <param name="data">Where it records read data</param>
        /// <returns>True or False if the file was read well</returns>
        public bool Read(string file, out string data)
        {
            try
            {
                string fileName = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, file);
                using (StreamReader sr = new StreamReader(fileName))
                {
                    data = sr.ReadToEnd();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new Exception($"Failed to read file: {file}");
            }
        }
    }
}
