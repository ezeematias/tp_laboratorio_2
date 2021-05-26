using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public sealed class Attendance : Device
    {

        public Attendance(ECode codeInternal, EType typeDevice, double serialNumber) : base(codeInternal, typeDevice, serialNumber)
        {

        }


        protected override bool Test()
        {
            bool output = false;
            if (base.Test() && Components.Contains(EComponents.Display) && !Components.Contains(EComponents.ModuleAccess))
            {
                output = true;
            }
            return output;
        }
    }
}
