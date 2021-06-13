using Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public class Components
    {
        EComponents nameComponent;
        int countComponent;

        /// <summary>
        /// Default builder to serialize
        /// </summary>
        public Components() { }

        /// <summary>
        /// Components builder.
        /// </summary>
        /// <param name="nameComponent">Name component</param>
        /// <param name="countComponent">Count component</param>
        public Components(EComponents nameComponent, int countComponent)
        {
            this.nameComponent = nameComponent;
            this.countComponent = countComponent;
        }

        /// <summary>
        /// Get and Set Name component
        /// </summary>
        public EComponents NameComponent { get => nameComponent; set => nameComponent = value; }
        /// <summary>
        /// Get and Set Count component
        /// </summary>
        public int CountComponent { get => countComponent; set => countComponent = value; }

        /// <summary>
        /// Operator overload between a cevice and a list to see if it exists. Compare by name and quantity.
        /// </summary>
        /// <param name="l">Component list</param>
        /// <param name="c">Component</param>
        /// <returns>True or false if there is stock of the component.</returns>
        public static bool operator ==(List<Components> l, Components c)
        {
            if (!(l is null && c is null))
            {
                foreach (Components item in l)
                {
                    if (item.NameComponent == c.NameComponent && item.CountComponent >= c.CountComponent)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Operator overload between a components and a list to see if it exists. Compare by name and quantity.
        /// </summary>
        /// <param name="l">Component list</param>
        /// <param name="c">Component</param>
        /// <returns>True or false if there is no stock of the component.</returns>
        public static bool operator !=(List<Components> l, Components c)
        {
            return !(l == c);
        }

        /// <summary>
        /// Operator overload between a components and a list to see if it exists and remove it.
        /// </summary>
        /// <param name="l">Component list</param>
        /// <param name="c">Component</param>
        /// <returns>True or false if it was removed successfully.</returns>
        public static bool operator -(List<Components> l, Components c)
        {
            if (!(l is null && c is null))
            {
                foreach (Components item in l)
                {
                    if (item.NameComponent == c.NameComponent && item.CountComponent >= c.CountComponent)
                    {
                        item.CountComponent -= c.CountComponent;
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Operator overload to add more quantity of a component.
        /// </summary>
        /// <param name="component">Components</param>
        /// <param name="count">Count</param>
        /// <returns>True or false if it was add successfully</returns>
        public static bool operator +(Components component, int count)
        {
            if (!(component is null) && count > 0)
            {
                foreach (Components item in Stock.ComponentsStock)
                {               
                    if(component.NameComponent == item.NameComponent)
                    {
                        item.CountComponent += count;
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Save a log when the list of components does not exist;
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool SaveErrorLogComponents(string data)
        {
            try
            {
                return new Text().Save(@"\LogErrorListComponents.txt", data + " " + DateTime.Now + "\n");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
