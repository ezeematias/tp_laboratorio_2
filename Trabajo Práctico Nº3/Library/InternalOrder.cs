using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class InternalOrder
    {
        private int numberOrder;
        private ECode nameDevice;
        private EValidation eValidation;
        private EType eTypeDevice;
        private int countDevice;

        public InternalOrder(int numberOrder, ECode nameDevice,EValidation eValidation ,EType eTypeDevice, int countDevice)
        {
            this.numberOrder = numberOrder;
            this.nameDevice = nameDevice;
            this.eTypeDevice = eTypeDevice;
            this.countDevice = countDevice;
            this.eValidation = eValidation;
        }
        public int NumberOrder { get => numberOrder; set => numberOrder = value; }
        public ECode NameDevice { get => nameDevice; set => nameDevice = value; }
        public EType ETypeDevice { get => eTypeDevice; set => eTypeDevice = value; }
        public int CountDevice { get => countDevice; set => countDevice = value; }
        public EValidation EValidation { get => eValidation; set => eValidation = value; }

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
