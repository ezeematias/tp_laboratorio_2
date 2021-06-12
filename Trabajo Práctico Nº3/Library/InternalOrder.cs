using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public class InternalOrder
    {
        private int numberOrder;
        private ECode nameDevice;
        private EType eTypeDevice;
        private int countDevice;

        public InternalOrder(int numberOrder, ECode nameDevice,EType eTypeDevice, int countDevice)
        {
            this.numberOrder = numberOrder;
            this.nameDevice = nameDevice;
            this.eTypeDevice = eTypeDevice;
            this.countDevice = countDevice;            
        }

        public int NumberOrder { get => this.numberOrder; set => this.numberOrder = value; }
        public ECode NameDevice { get => this.nameDevice; set => this.nameDevice = value; }
        public EType ETypeDevice { get => this.eTypeDevice; set => this.eTypeDevice = value; }
        public int CountDevice { get => this.countDevice; set => this.countDevice = value; }
        

        public static bool operator ==(List<InternalOrder> l, InternalOrder o)
        {
            if (!(l is null && o is null))
            {
                foreach (InternalOrder item in l)
                {
                    if (item.NumberOrder == o.NumberOrder)
                    {
                        return true;
                    }
                }                
            }
            return false;
        }

        public static bool operator !=(List<InternalOrder> l, InternalOrder o)
        {
            return !(l == o);
        }
    }
}
