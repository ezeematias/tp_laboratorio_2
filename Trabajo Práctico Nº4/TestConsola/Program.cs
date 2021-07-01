using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Reading serialized files
                Stock.ReadComponents();
                Stock.ReadDevices();
                SerialsNumbers.ReadSerialsNumbers();

                // Login operator
                LoginOperators.Login.OperatorLog = new LoginOperators.Operator("Test", "Console", 9999, 9999);

                // Work order selection
                CoreSystem.SelectedOrder = new InternalOrder(9999, ECode.CNT_BioPanel_ACC, EType.PanelAccess, 3);

                // Device creation using your own creation method
                CoreSystem.LoadDevices(EType.PanelAccess, EValidation.Finger);
                CoreSystem.PreviewDevices.Add(CoreSystem.DeviceAssembly);

                // Manual addition of device                
                CoreSystem.PreviewDevices.Add(new AccessControl(ECode.CNT_A60_ID, EType.AccessControl, EValidation.Finger));
                CoreSystem.PreviewDevices.Add(new AccessPanel(ECode.CNT_BioPanel_ACC, EType.PanelAccess, 2, EValidation.Finger));
                CoreSystem.PreviewDevices.Add(new Attendance(ECode.CNT_E7_CR, EType.Attendance, EValidation.Finger));
                
                // All data in the list is printed
                Console.WriteLine(Device.Info(CoreSystem.PreviewDevices));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
