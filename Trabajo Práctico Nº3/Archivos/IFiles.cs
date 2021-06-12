using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    public interface IFiles<T>
    {
        /// <summary>
        /// Saves the data it receives as a parameter in a file
        /// </summary>
        /// <param name="file">File path </param>
        /// <param name="data">Data to save</param>
        /// <returns>True or False if the file was saved well</returns>
        bool Save(string file, T data);

        /// <summary>
        /// Read saved data from a file
        /// </summary>
        /// <param name="file">File path</param>
        /// <param name="data">Where it records read data</param>
        /// <returns>True or False if the file was read well</returns>
        bool Read(string file, out T data);
    }
}
