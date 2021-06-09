using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            LoadComponentsStock();
        }

        private static void LoadComponentsStock()
        {
            ComponentsStock.Add(new Components(EComponents.Mother, 100));
            ComponentsStock.Add(new Components(EComponents.Core, 100));
            ComponentsStock.Add(new Components(EComponents.Package, 100));
            ComponentsStock.Add(new Components(EComponents.Case, 100));
            ComponentsStock.Add(new Components(EComponents.Display, 100));
            ComponentsStock.Add(new Components(EComponents.Touch, 100));
            ComponentsStock.Add(new Components(EComponents.Keyboard, 100));
            ComponentsStock.Add(new Components(EComponents.Led, 100));
            ComponentsStock.Add(new Components(EComponents.FingerPrint, 100));
            ComponentsStock.Add(new Components(EComponents.Camera, 100));
            ComponentsStock.Add(new Components(EComponents.RFID, 100));
            ComponentsStock.Add(new Components(EComponents.Relay, 100));
            ComponentsStock.Add(new Components(EComponents.Face, 100));
            ComponentsStock.Add(new Components(EComponents.TimeLog, 100));
            ComponentsStock.Add(new Components(EComponents.Sound, 100));
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
    }
}
