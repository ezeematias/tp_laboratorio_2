using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public class SerializeSN
    {
        private double accessControl;
        private double attendance;
        private double panelAccess;

        public SerializeSN()
        {
            
        }

        public double AccessControl { get => accessControl; set => accessControl = value; }
        public double Attendance { get => attendance; set => attendance = value; }
        public double PanelAccess { get => panelAccess; set => panelAccess = value; }

    }
}
