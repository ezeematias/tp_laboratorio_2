using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Components
    {
        EComponents nameComponent;
        int countComponent;

        public Components(EComponents nameComponent, int countComponent)
        {
            this.nameComponent = nameComponent;
            this.countComponent = countComponent;
        }

        public EComponents NameComponent { get => nameComponent; set => nameComponent = value; }
        public int CountComponent { get => countComponent; set => countComponent = value; }

        
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

        public static bool operator !=(List<Components> l, Components c)
        {
            return !(l == c);
        }
        
        
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
        

        /*
        public static bool operator -(List<Components> l, List<Components> c)
        {
            if (!(l is null && c is null))
            {
                foreach (Components itemL in l)
                {
                    foreach (Components itemC in c)
                    {
                        if (itemL.NameComponent == itemC.NameComponent && itemL.CountComponent >= itemC.CountComponent)
                        {
                            itemL.CountComponent -= itemC.CountComponent;
                            return true;
                        }                    
                    }
                }
            }
            return false;
        }
        */

    }
}
