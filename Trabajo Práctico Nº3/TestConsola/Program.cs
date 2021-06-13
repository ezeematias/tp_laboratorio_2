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
            Stock.ReadDevices();
            SerialsNumbers.ReadSerialsNumbers();
            List<Device> listDevices = new List<Device>();

            listDevices.Add(new AccessControl(ECode.CNT_A60_ID, EType.AccessControl, EValidation.Finger));
            listDevices.Add(new AccessPanel(ECode.CNT_BioPanel_ACC, EType.PanelAccess, 2, EValidation.Card));
            listDevices.Add(new Attendance(ECode.CNT_E7_CR, EType.Attendance, EValidation.Face));

            foreach (Device item in listDevices)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
