using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class SerialsNumbers
    {
        static double accessControl;
        static double attendance;
        static double panelAccess;

        static SerialsNumbers()
        {
            accessControl = 4000015970;
            attendance = 5000055137;
            panelAccess = 6000027917;
        }

        public static double AccessControl { get => accessControl; set => accessControl = value; }
        public static double Attendance { get => attendance; set => attendance = value; }
        public static double PanelAccess { get => panelAccess; set => panelAccess = value; }

        public static double GetAndSetSerialNumber(EType eType)
        {
            double output = 0;
            switch (eType)
            {
                case EType.AccessControl:
                    accessControl++;
                    output = accessControl;
                    break;
                case EType.PanelAccess:
                    PanelAccess++;
                    output = PanelAccess;
                    break;
                case EType.Attendance:
                    Attendance++;
                    output = Attendance;
                    break;
            }
            return output;
        }

        public static double GetSerialNumberByType(EType eType)
        {
            double output = 0;
            switch (eType)
            {
                case EType.AccessControl:                    
                    output = accessControl;
                    break;
                case EType.PanelAccess:                    
                    output = PanelAccess;
                    break;
                case EType.Attendance:                    
                    output = Attendance;
                    break;
            }
            return output;
        }



    }
}
