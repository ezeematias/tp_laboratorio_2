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

        /// <summary>
        /// Builder default.
        /// </summary>
        static SerialsNumbers() { }

        /// <summary>
        /// Get and Set AccessControl
        /// </summary>
        public static double AccessControl { get => accessControl; set => accessControl = value; }

        /// <summary>
        /// Get and Set Attendance
        /// </summary>
        public static double Attendance { get => attendance; set => attendance = value; }

        /// <summary>
        /// Get and Set PanelAccess
        /// </summary>
        public static double PanelAccess { get => panelAccess; set => panelAccess = value; }

        /// <summary>
        /// Get and Set Serial number
        /// </summary>
        /// <param name="eType">Type de devices</param>
        /// <returns>New Serial Number</returns>
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

        /// <summary>
        /// Get Serial Number
        /// </summary>
        /// <param name="eType">Type de devices</param>
        /// <returns>Last Serial Number</returns>
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

        /// <summary>
        /// Read the file with the serial numbers and set them.
        /// </summary>
        public static void ReadSerialsNumbers()
        {
            try
            {
                SerializeSN aux = new SerializeSN();
                if (new Xml<SerializeSN>().Read("\\SerialsNumbers.xml", out aux))
                {
                    AccessControl = aux.AccessControl;
                    Attendance = aux.Attendance;
                    PanelAccess = aux.PanelAccess;
                }
            }
            catch (Exception ex)
            {                
                throw new Exception("The file with the serial numbers could not be found.", ex);
            }
        }

        /// <summary>
        /// Save the serial numbers to a file.
        /// </summary>
        /// <returns>True or false</returns>
        public static bool SaveSerialsNumbers()
        {
            try
            {
                SerializeSN aux = new SerializeSN();
                aux.AccessControl = AccessControl;
                aux.Attendance = Attendance;
                aux.PanelAccess = PanelAccess;
                if (new Xml<SerializeSN>().Save(@"\SerialsNumbers.xml", aux))
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
