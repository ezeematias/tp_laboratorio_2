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
        private EType eTypeDevice;
        private int countDevice;

        public InternalOrder(int numberOrder, ECode nameDevice, EType eTypeDevice, int countDevice)
        {
            this.numberOrder = numberOrder;
            this.nameDevice = nameDevice;
            this.eTypeDevice = eTypeDevice;
            this.countDevice = countDevice;
        }
        public int NumberOrder { get => numberOrder; set => numberOrder = value; }
        public ECode NameDevice { get => nameDevice; set => nameDevice = value; }
        public EType ETypeDevice { get => eTypeDevice; set => eTypeDevice = value; }
        public int CountDevice { get => countDevice; set => countDevice = value; }
    }
}
