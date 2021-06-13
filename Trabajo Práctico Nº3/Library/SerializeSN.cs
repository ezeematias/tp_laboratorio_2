using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Exclusive class for serializing serial numbers.
    /// </summary>
    [Serializable]
    public class SerializeSN
    {
        private double accessControl;
        private double attendance;
        private double panelAccess;

        /// <summary>
        /// Default builder to serialize
        /// </summary>
        public SerializeSN() { }

        /// <summary>
        /// Get and Set AccessControl
        /// </summary>
        public double AccessControl { get => accessControl; set => accessControl = value; }

        /// <summary>
        /// Get and Set Attendance
        /// </summary>
        public double Attendance { get => attendance; set => attendance = value; }

        /// <summary>
        /// Get and Set PanelAccess
        /// </summary>
        public double PanelAccess { get => panelAccess; set => panelAccess = value; }
    }
}
