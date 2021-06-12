using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Files;

namespace Library
{
    public static class Stock
    {
        static List<Device> devicesStock;
        static List<Components> componentsStock;

        public static List<Device> DevicesStock { get => devicesStock; set => devicesStock = value; }
        public static List<Components> ComponentsStock { get => componentsStock; set => componentsStock = value; }

        static Stock()
        {
            devicesStock = new List<Device>();
            componentsStock = new List<Components>();
            ReadComponents();
            ReadDevices();            
        }       

        public static bool ThereIsStock(List<Components> components, out string eComponents)
        {
            bool output = false;
            bool aux = false;
            eComponents = "Null";
            StringBuilder sb = new StringBuilder();
            foreach (Components item in components)
            {
                if (ComponentsStock == item)
                {
                    output = true;
                }
                else
                {
                    sb.AppendLine($" * {item.NameComponent}");
                    aux = true;                    
                }
            }
            if(aux)
            {
                eComponents = sb.ToString();
                output = false;
            }
            return output;
        }

        public static bool ChargedComponent(List<Components> components)
        {
            bool output = false;
            foreach (Components item in components)
            {
                if (ComponentsStock - item)
                {
                    output = true;
                }
                else
                {
                    output = false;
                    break;
                }
            }
            return output;
        }

        public static void ReadDevices()
        {
            try
            {
                List<Device> aux = new List<Device>();
                if (new Xml<List<Device>>().Read("DevicesStock.xml", out aux))
                {
                    devicesStock = aux;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool SaveDevices()
        {
            try
            {
                if (new Xml<List<Device>>().Save("DevicesStock.xml", devicesStock))
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

        public static void ReadComponents()
        {
            try
            {
                List<Components> aux = new List<Components>();
                if (new Xml<List<Components>>().Read("ComponentsStock.xml", out aux))
                {
                    componentsStock = aux;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool SaveComponents()
        {
            try
            {
                if (new Xml<List<Components>>().Save("ComponentsStock.xml", componentsStock))
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
