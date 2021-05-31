using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class CoreSystem
    {
        static List<Operator> operators;
        static List<InternalOrder> internalOrders;       
        static InternalOrder selectedOrder;
        static List<Device> devicesStock;
        static List<Device> previewDevices;
        static List<Components> componentsStock;
        static Device deviceAssembly;
        /*
        static Attendance attendanceAssembly;
        static AccessControl accessControlAssembly;
        static AccessPanel panelAccessAssembly;
        */

        public static List<Operator> Operators { get => operators; }
        public static List<InternalOrder> InternalOrders { get => internalOrders; set => internalOrders = value; }
        public static List<Device> DevicesStock { get => devicesStock; set => devicesStock = value; }
        public static List<Components> ComponentsStock { get => componentsStock; set => componentsStock = value; }
        public static InternalOrder SelectedOrder { get => selectedOrder; set => selectedOrder = value; }
        public static List<Device> PreviewDevices { get => previewDevices; set => previewDevices = value; }
        public static Device DeviceAssembly { get => deviceAssembly; set => deviceAssembly = value; }


        /*
         public static Attendance AttendanceAssembly { get => attendanceAssembly; set => attendanceAssembly = value; }
         public static AccessControl AccessControlAssembly { get => accessControlAssembly; set => accessControlAssembly = value; }
         public static AccessPanel PanelAccessAssembly { get => panelAccessAssembly; set => panelAccessAssembly = value; }
        */
        static CoreSystem()
        {
            operators = new List<Operator>();
            internalOrders = new List<InternalOrder>();
            previewDevices = new List<Device>();
            devicesStock = new List<Device>();
            componentsStock = new List<Components>();            
            LoadOperators();
            LoadInternalOrder();
            LoadComponentsStock();
        }

        private static void LoadOperators()
        {
            Operators.Add(new Operator("Ezequiel", "Unía", 6666, 9999));
            Operators.Add(new Operator("Federico", "Dávila", 8080, 7845));
            Operators.Add(new Operator("Mauricio", "Cerizza", 7894, 5020));
            Operators.Add(new Operator("Ezequiel", "Oggioni", 4747, 3030));
            Operators.Add(new Operator("Esteban", "Prieto", 9595, 1331));
            Operators.Add(new Operator("Lautaro", "Galarza", 4747, 3030));
            Operators.Add(new Operator("Lucas", "Rodríguez", 1010, 2020));
        }

        private static void LoadInternalOrder()
        {
            InternalOrders.Add(new InternalOrder(4506, ECode.CNT_A60_ID, EValidation.Finger,EType.AccessControl, 2));
            InternalOrders.Add(new InternalOrder(4507, ECode.CNT_A9_CR, EValidation.Card,EType.AccessControl, 1));
            InternalOrders.Add(new InternalOrder(4508, ECode.CNT_BioPanel_ACC, EValidation.Finger,EType.PanelAccess, 3));
            InternalOrders.Add(new InternalOrder(4509, ECode.CNT_FD10_FC, EValidation.Face,EType.Attendance, 2));
            InternalOrders.Add(new InternalOrder(4510, ECode.CNT_E7_CR, EValidation.Card,EType.Attendance, 1));
        }

        private static void LoadComponentsStock()
        {
            ComponentsStock.Add(new Components(EComponents.Mother, 10));
            ComponentsStock.Add(new Components(EComponents.Core, 10));
            ComponentsStock.Add(new Components(EComponents.Package, 10));
            ComponentsStock.Add(new Components(EComponents.Case, 10));
            ComponentsStock.Add(new Components(EComponents.Display, 10));
            ComponentsStock.Add(new Components(EComponents.Touch, 10));
            ComponentsStock.Add(new Components(EComponents.Keyboard, 10));
            ComponentsStock.Add(new Components(EComponents.Led, 10));
            ComponentsStock.Add(new Components(EComponents.FingerPrint, 10));
            ComponentsStock.Add(new Components(EComponents.Camera, 10));
            ComponentsStock.Add(new Components(EComponents.RFID, 10));
            ComponentsStock.Add(new Components(EComponents.Temp, 10));
            ComponentsStock.Add(new Components(EComponents.Relay, 10));
            ComponentsStock.Add(new Components(EComponents.Face, 10));
            ComponentsStock.Add(new Components(EComponents.TimeLog, 10));
            ComponentsStock.Add(new Components(EComponents.Sound, 10));            
        }
        
        public static bool UseComponent(Components component)
        {       
            return (ComponentsStock - component);
        }
    }
}
