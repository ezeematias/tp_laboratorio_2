using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Files;

namespace Library
{
    public static class SerialsNumbers
    {
        static double accessControl;
        static double attendance;
        static double panelAccess;

        static SerialsNumbers()
        {
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
                    output = AccessControl;
                    AccessControl++;
                    break;
                case EType.PanelAccess:
                    output = PanelAccess;
                    PanelAccess++;
                    break;
                case EType.Attendance:
                    output = Attendance;
                    Attendance++;
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
                    output = AccessControl;
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

        public static void ReadSerialsNumbers()
        {
            try
            {
                SerializeSN aux = new SerializeSN();
                if (new Xml<SerializeSN>().Read("SerialsNumbers.xml", out aux))
                {
                    AccessControl = aux.AccessControl;
                    Attendance = aux.Attendance;
                    PanelAccess = aux.PanelAccess;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool SaveSerialsNumbers()
        {
            try
            {
                SerializeSN aux = new SerializeSN();
                aux.AccessControl = AccessControl;
                aux.Attendance = Attendance;
                aux.PanelAccess = PanelAccess;
                if (new Xml<SerializeSN>().Save("SerialsNumbers.xml", aux))
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
