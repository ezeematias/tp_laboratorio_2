using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Components
    {
        string nameComponent;
        int countComponent;

        public Components(string nameComponent, int countComponent)
        {
            this.nameComponent = nameComponent;
            this.countComponent = countComponent;
        }

        public string NameComponent { get => nameComponent; set => nameComponent = value; }

        public int CountComponent 
        { get
            {
                return countComponent;
            }           
          set
            {
                this.countComponent = value; 
            }
        }
    }
}
