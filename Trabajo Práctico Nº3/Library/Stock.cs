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

        /// <summary>
        /// Get and Set DevicesStock
        /// </summary>
        public static List<Device> DevicesStock { get => devicesStock; set => devicesStock = value; }

        /// <summary>
        /// Get and Set ComponentsStock
        /// </summary>
        public static List<Components> ComponentsStock { get => componentsStock; set => componentsStock = value; }

        /// <summary>
        /// Builder default
        /// </summary>
        static Stock()
        {
            DevicesStock = new List<Device>();
            ComponentsStock = new List<Components>();
        }

        /// <summary>
        /// Checks for stock and returns missing components by reference.
        /// </summary>
        /// <param name="components">Components to control</param>
        /// <param name="eComponents">String out the components</param>
        /// <returns>True or false if there is stock // If it is false, Returns by reference a string with all the components without stock</returns>
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
            if (aux)
            {
                eComponents = sb.ToString();
                output = false;
            }
            return output;
        }

        /// <summary>
        /// Load component list and subtract from stock.
        /// </summary>
        /// <param name="components">component list</param>
        /// <returns>True or false if the list was successfully loaded.</returns>
        public static bool ChargedComponent(List<Components> components)
        {
            bool output = false;
            foreach (Components item in components)
            {
                if (ComponentsStock - item)
                {
                    output = true;
                    SaveComponents();
                }
                else
                {
                    output = false;
                    break;
                }
            }
            return output;
        }

        /// <summary>
        /// Read the file with the Devices and set them.
        /// </summary>
        public static void ReadDevices()
        {
            try
            {
                List<Device> aux = new List<Device>();
                if (new Xml<List<Device>>().Read(@"\DevicesStock.xml", out aux))
                {
                    DevicesStock = aux;
                }
            }
            catch (Exception ex)
            {
                SaveDevices();
                throw ex;
            }
        }

        /// <summary>
        /// Save the Devices to a file.
        /// </summary>
        /// <returns>True or false</returns>
        public static bool SaveDevices()
        {
            try
            {
                if (new Xml<List<Device>>().Save(@"\DevicesStock.xml", devicesStock))
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

        /// <summary>
        /// Read the file with the Components and set them.
        /// </summary>
        public static void ReadComponents()
        {
            try
            {
                List<Components> aux = new List<Components>();
                if (new Xml<List<Components>>().Read(@"\ComponentsStock.xml", out aux))
                {
                    ComponentsStock = aux;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("A new list was created because a loaded one was not found.\nGo to Stock> Components to reset the list of components.", ex);
            }
        }

        /// <summary>
        /// Save the Components to a file.
        /// </summary>
        /// <returns>True or false</returns>
        public static bool SaveComponents()
        {
            try
            {
                if (new Xml<List<Components>>().Save(@"\ComponentsStock.xml", componentsStock))
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

        /// <summary>
        /// In case of failure to read the components, a new list is created with zero stock.
        /// </summary>
        public static void InitializeComponents()
        {
            componentsStock.Add(new Components(EComponents.Mother, 0));
            componentsStock.Add(new Components(EComponents.Core, 0));
            componentsStock.Add(new Components(EComponents.Package, 0));
            componentsStock.Add(new Components(EComponents.Case, 0));
            componentsStock.Add(new Components(EComponents.Display, 0));
            componentsStock.Add(new Components(EComponents.Keyboard, 0));
            componentsStock.Add(new Components(EComponents.Led, 0));
            componentsStock.Add(new Components(EComponents.Sound, 0));
            componentsStock.Add(new Components(EComponents.RFID, 0));
            componentsStock.Add(new Components(EComponents.Face, 0));
            componentsStock.Add(new Components(EComponents.Camera, 0));
            componentsStock.Add(new Components(EComponents.Relay, 0));
            componentsStock.Add(new Components(EComponents.FingerPrint, 0));
            componentsStock.Add(new Components(EComponents.TimeLog, 0));
            SaveComponents();
        }

        /// <summary>
        /// Updates the stock with the information from the previous list.
        /// </summary>
        public static void UpdateDevicesStock()
        {
            Stock.DevicesStock.AddRange(CoreSystem.PreviewDevices);            
            CoreSystem.PreviewDevices.Clear();
        }
    }
}
