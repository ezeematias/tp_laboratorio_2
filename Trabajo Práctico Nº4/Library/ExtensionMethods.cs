using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Extension of a list of components where it compares the received name and returns the item from the list.
        /// </summary>
        /// <param name="components"> List Components</param>
        /// <param name="name">Component name</param>
        /// <returns>Component</returns>
        public static Components DataExtension(this List<Components> components, string name)
        {
            foreach (Components item in components)
            {
                if(item.NameComponent.ToString() == name)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
