using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public static class CoreSystem
    {
        static List<InternalOrder> internalOrders;
        static InternalOrder selectedOrder;
        static List<Device> previewDevices;
        static List<Components> componentsAccFace;
        static List<Components> componentsAccFinger;
        static List<Components> componentsAttFace;
        static List<Components> componentsAttFinger;
        static List<Components> componentsPnlRFID;
        static List<Components> componentsPnlFinger;
        static Device deviceAssembly;
        static List<Components> listAssembly;

        /// <summary>
        /// Get and Set InternalOrders
        /// </summary>
        public static List<InternalOrder> InternalOrders { get => internalOrders; set => internalOrders = value; }
        /// <summary>
        /// Get and Set SelectedOrder
        /// </summary>
        public static InternalOrder SelectedOrder { get => selectedOrder; set => selectedOrder = value; }
        /// <summary>
        /// Get and Set PreviewDevices
        /// </summary>
        public static List<Device> PreviewDevices { get => previewDevices; set => previewDevices = value; }
        /// <summary>
        /// Get and Set DeviceAssembly
        /// </summary>
        public static Device DeviceAssembly { get => deviceAssembly; set => deviceAssembly = value; }
        /// <summary>
        /// Get and Set ComponentsAccFace
        /// </summary>
        public static List<Components> ComponentsAccFace { get => componentsAccFace; set => componentsAccFace = value; }
        /// <summary>
        /// Get and Set ComponentsAccFinger
        /// </summary>
        public static List<Components> ComponentsAccFinger { get => componentsAccFinger; set => componentsAccFinger = value; }
        /// <summary>
        /// Get and Set ComponentsAttFace
        /// </summary>
        public static List<Components> ComponentsAttFace { get => componentsAttFace; set => componentsAttFace = value; }
        /// <summary>
        /// Get and Set ComponentsAttFinger
        /// </summary>
        public static List<Components> ComponentsAttFinger { get => componentsAttFinger; set => componentsAttFinger = value; }
        /// <summary>
        /// Get and Set ComponentsPnlRFID
        /// </summary>
        public static List<Components> ComponentsPnlRFID { get => componentsPnlRFID; set => componentsPnlRFID = value; }
        /// <summary>
        /// Get and Set ComponentsPnlFinger
        /// </summary>
        public static List<Components> ComponentsPnlFinger { get => componentsPnlFinger; set => componentsPnlFinger = value; }
        /// <summary>
        /// Get and Set ListAssembly
        /// </summary>
        public static List<Components> ListAssembly { get => listAssembly; set => listAssembly = value; }

        /// <summary>
        /// Builder CoreSystem
        /// </summary>
        static CoreSystem()
        {
            internalOrders = new List<InternalOrder>();
            previewDevices = new List<Device>();
            componentsAccFace = new List<Components>();
            componentsAccFinger = new List<Components>();
            componentsAttFace = new List<Components>();
            componentsAttFinger = new List<Components>();
            componentsPnlRFID = new List<Components>();
            componentsPnlFinger = new List<Components>();
            listAssembly = new List<Components>();

            LoadBasicComponents(componentsAccFace);
            LoadBasicComponents(componentsAccFinger);
            LoadBasicComponents(componentsAttFace);
            LoadBasicComponents(componentsAttFinger);
            LoadBasicComponents(componentsPnlRFID);
            LoadBasicComponents(componentsPnlFinger);
            LoadAccFaceComponents();
            LoadAccFingerComponents();
            LoadAttFaceComponents();
            LoadAttFingerComponents();
            LoadPnlFingerComponents();
            LoadPnlRFIDComponents();  

        }

        /// <summary>
        /// Basic component list loading for devices.
        /// </summary>
        /// <param name="list">Components list</param>
        private static void LoadBasicComponents(List<Components> list)
        {
            list.Add(new Components(EComponents.Mother, 1));
            list.Add(new Components(EComponents.Core, 10));
            list.Add(new Components(EComponents.Package, 10));
            list.Add(new Components(EComponents.Case, 10));
            list.Add(new Components(EComponents.Display, 10));
            list.Add(new Components(EComponents.Keyboard, 10));
            list.Add(new Components(EComponents.Led, 10));
            list.Add(new Components(EComponents.Sound, 2));
            list.Add(new Components(EComponents.RFID, 1));
        }

        /// <summary>
        /// List of components for charging an Access and Facial device.
        /// </summary>
        private static void LoadAccFaceComponents()
        {
            componentsAccFace.Add(new Components(EComponents.Face, 1));
            componentsAccFace.Add(new Components(EComponents.Camera, 1));
            componentsAccFace.Add(new Components(EComponents.Relay, 1));
        }

        /// <summary>
        /// List of components for charging an Access and Finger device.
        /// </summary>
        private static void LoadAccFingerComponents()
        {
            componentsAccFinger.Add(new Components(EComponents.FingerPrint, 1));
            componentsAccFinger.Add(new Components(EComponents.Relay, 1));
        }

        /// <summary>
        /// List of components for charging an Attendance and Finger device.
        /// </summary>
        private static void LoadAttFingerComponents()
        {
            componentsAttFinger.Add(new Components(EComponents.FingerPrint, 1));
            componentsAttFinger.Add(new Components(EComponents.RFID, 1));
            componentsAttFinger.Add(new Components(EComponents.TimeLog, 1));
        }

        /// <summary>
        /// List of components for charging an Attendance and Facial device.
        /// </summary>
        private static void LoadAttFaceComponents()
        {
            componentsAttFace.Add(new Components(EComponents.Face, 1));
            componentsAttFace.Add(new Components(EComponents.RFID, 1));
            componentsAttFace.Add(new Components(EComponents.Camera, 1));
            componentsAttFace.Add(new Components(EComponents.TimeLog, 1));
        }

        /// <summary>
        /// List of components for charging an Panel Access and Card device.
        /// </summary>
        private static void LoadPnlRFIDComponents()
        {
            componentsPnlRFID.Add(new Components(EComponents.RFID, 1));
            componentsPnlRFID.Add(new Components(EComponents.Relay, 2));
        }

        /// <summary>
        /// List of components for charging an Panel Access and Finger device.
        /// </summary>
        private static void LoadPnlFingerComponents()
        {
            componentsPnlFinger.Add(new Components(EComponents.FingerPrint, 1));
            componentsPnlFinger.Add(new Components(EComponents.Relay, 2));
            componentsPnlFinger.Add(new Components(EComponents.RFID, 1));
        }

        /// <summary>
        /// Device stacking according to your type and validation
        /// </summary>
        /// <param name="eType">Typo the device</param>
        /// <param name="eValidation">Validation the device</param>
        public static void LoadDevices(EType eType, EValidation eValidation)
        {
            try
            {
                switch (eType)
                {
                    case EType.AccessControl:
                        DeviceAssembly = new AccessControl(SelectedOrder.NameDevice, EType.AccessControl, eValidation);
                        break;

                    case EType.PanelAccess:
                        DeviceAssembly = new AccessPanel(SelectedOrder.NameDevice, EType.PanelAccess, eValidation);
                        break;

                    case EType.Attendance:
                        DeviceAssembly = new Attendance(SelectedOrder.NameDevice, EType.Attendance, eValidation);
                        break;
                }
            }
            catch (Exception)
            {
                throw new Exception("The device was not created.");
            }
        }

        /// <summary>
        /// Definitive list upload for devices depending on your type and validation.
        /// </summary>
        /// <param name="eType">Typo the device</param>
        /// <param name="eValidation">Validation the device</param>
        public static void LoadListAssembly(EType eType, EValidation eValidation)
        {
            switch (eType)
            {
                case EType.AccessControl:
                    if (eValidation == EValidation.Finger)
                    {
                        ListAssembly = ComponentsAccFinger;
                    }
                    else
                    {
                        ListAssembly = ComponentsAccFace;
                    }
                    break;

                case EType.PanelAccess:
                    if (eValidation == EValidation.Finger)
                    {
                        ListAssembly = ComponentsPnlFinger;
                    }
                    else
                    {
                        ListAssembly = ComponentsPnlRFID;
                    }
                    break;
                case EType.Attendance:
                    if (eValidation == EValidation.Finger)
                    {
                        ListAssembly = ComponentsAttFinger;
                    }
                    else
                    {
                        ListAssembly = ComponentsAttFace;
                    }
                    break;
            }
        }
    }
}
