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

        public static List<InternalOrder> InternalOrders { get => internalOrders; set => internalOrders = value; }
        public static InternalOrder SelectedOrder { get => selectedOrder; set => selectedOrder = value; }
        public static List<Device> PreviewDevices { get => previewDevices; set => previewDevices = value; }
        public static Device DeviceAssembly { get => deviceAssembly; set => deviceAssembly = value; }
        public static List<Components> ComponentsAccFace { get => componentsAccFace; set => componentsAccFace = value; }
        public static List<Components> ComponentsAccFinger { get => componentsAccFinger; set => componentsAccFinger = value; }
        public static List<Components> ComponentsAttFace { get => componentsAttFace; set => componentsAttFace = value; }
        public static List<Components> ComponentsAttFinger { get => componentsAttFinger; set => componentsAttFinger = value; }
        public static List<Components> ComponentsPnlRFID { get => componentsPnlRFID; set => componentsPnlRFID = value; }
        public static List<Components> ComponentsPnlFinger { get => componentsPnlFinger; set => componentsPnlFinger = value; }
        public static List<Components> ListAssembly { get => listAssembly; set => listAssembly = value; }

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

            LoadInternalOrder();
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

        private static void LoadInternalOrder()
        {
            InternalOrders.Add(new InternalOrder(4506, ECode.CNT_A60_ID, EType.AccessControl, 2));
            InternalOrders.Add(new InternalOrder(4507, ECode.CNT_A9_FC, EType.AccessControl, 1));
            InternalOrders.Add(new InternalOrder(4508, ECode.CNT_BioPanel_ACC, EType.PanelAccess, 3));
            InternalOrders.Add(new InternalOrder(4509, ECode.CNT_FD10_FC, EType.Attendance, 2));
            InternalOrders.Add(new InternalOrder(4510, ECode.CNT_E7_CR, EType.Attendance, 1));
        }

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

        private static void LoadAccFaceComponents()
        {
            componentsAccFace.Add(new Components(EComponents.Face, 1));
            componentsAccFace.Add(new Components(EComponents.Camera, 1));
            componentsAccFace.Add(new Components(EComponents.Relay, 1));
        }
        private static void LoadAccFingerComponents()
        {
            componentsAccFinger.Add(new Components(EComponents.FingerPrint, 1));
            componentsAccFinger.Add(new Components(EComponents.Relay, 1));
        }

        private static void LoadAttFingerComponents()
        {
            componentsAttFinger.Add(new Components(EComponents.FingerPrint, 1));
            componentsAttFinger.Add(new Components(EComponents.RFID, 1));
            componentsAttFinger.Add(new Components(EComponents.TimeLog, 1));
        }
        private static void LoadAttFaceComponents()
        {
            componentsAttFace.Add(new Components(EComponents.Face, 1));
            componentsAttFace.Add(new Components(EComponents.RFID, 1));
            componentsAttFace.Add(new Components(EComponents.Camera, 1));
            componentsAttFace.Add(new Components(EComponents.TimeLog, 1));
        }
        private static void LoadPnlRFIDComponents()
        {
            componentsPnlRFID.Add(new Components(EComponents.RFID, 1));
            componentsPnlRFID.Add(new Components(EComponents.Relay, 2));
        }
        private static void LoadPnlFingerComponents()
        {
            componentsPnlFinger.Add(new Components(EComponents.FingerPrint, 1));
            componentsPnlFinger.Add(new Components(EComponents.Relay, 2));
            componentsPnlFinger.Add(new Components(EComponents.RFID, 1));
        }


        public static void LoadDevices(EType eType, EValidation eValidation)
        {
            switch (eType)
            {
                case EType.AccessControl:
                        DeviceAssembly = new AccessControl(SelectedOrder.NameDevice, EType.AccessControl, eValidation);           
                    break;

                case EType.PanelAccess:
                        DeviceAssembly = new AccessPanel(SelectedOrder.NameDevice, EType.PanelAccess, 2, eValidation);
                    break;

                case EType.Attendance:
                        DeviceAssembly = new Attendance(SelectedOrder.NameDevice, EType.Attendance, eValidation);
                    break;
            }
        }

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
