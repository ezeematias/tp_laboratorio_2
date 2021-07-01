using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Files;

namespace Library
{
    [Serializable]
    public class InternalOrder
    {
        private int numberOrder;
        private ECode nameDevice;
        private EType eTypeDevice;
        private int countDevice;

        /// <summary>
        /// Default builder to serialize
        /// </summary>
        public InternalOrder() { }

        /// <summary>
        /// Builder Internal Orders
        /// </summary>
        /// <param name="numberOrder">Number order</param>
        /// <param name="nameDevice">Code the devices</param>
        /// <param name="eTypeDevice">Type the devices</param>
        /// <param name="countDevice">Count the devices</param>
        public InternalOrder(int numberOrder, ECode nameDevice,EType eTypeDevice, int countDevice)
        {
            this.numberOrder = numberOrder;
            this.nameDevice = nameDevice;
            this.eTypeDevice = eTypeDevice;
            this.countDevice = countDevice;            
        }

        /// <summary>
        /// Get and Sett NumberOrder
        /// </summary>
        public int NumberOrder { get => this.numberOrder; set => this.numberOrder = value; }
        /// <summary>
        /// Get and Sett NameDevice
        /// </summary>
        public ECode NameDevice { get => this.nameDevice; set => this.nameDevice = value; }
        /// <summary>
        /// Get and Sett ETypeDevice
        /// </summary>
        public EType ETypeDevice { get => this.eTypeDevice; set => this.eTypeDevice = value; }
        /// <summary>
        /// Get and Sett CountDevice
        /// </summary>
        public int CountDevice { get => this.countDevice; set => this.countDevice = value; }

        /// <summary>
        /// Operator overload between a Order and a list to see if it exists. Compare by number order.
        /// </summary>
        /// <param name="l">InternalOrder list</param>
        /// <param name="c">InternalOrder</param>
        /// <returns>True or false if there is stock of the InternalOrder.</returns>
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

        /// <summary>
        /// Operator overload between a Order and a list to see if it exists. Compare by number order.
        /// </summary>
        /// <param name="l">InternalOrder list</param>
        /// <param name="c">InternalOrder</param>
        /// <returns>True or false if there is no stock of the InternalOrder.</returns>
        public static bool operator !=(List<InternalOrder> l, InternalOrder o)
        {
            return !(l == o);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool SaveErrorLogOrder(string data)
        {
            try
            {
                return new Text().Save(@"\LogErrorInternalOrder.txt", $"{LoginOperators.Login.OperatorLog} You have no work orders to perform {DateTime.Now}\n{data}\n\n");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Saves the data Internal order in a file
        /// </summary>
        public static void ReadInternalOrder()
        {
            try
            {
                List<InternalOrder> aux = new List<InternalOrder>();
                if (new Xml<List<InternalOrder>>().Read(@"\InternalOrders.xml", out aux))
                {
                    CoreSystem.InternalOrders = aux;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Read the data Internal order in a file
        /// </summary>
        public static bool SaveInternalOrder()
        {
            try
            {
                if (new Xml<List<InternalOrder>>().Save(@"\InternalOrders.xml", CoreSystem.InternalOrders))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
