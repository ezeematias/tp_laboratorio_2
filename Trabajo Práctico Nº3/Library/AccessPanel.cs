using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class AccessPanel : Device
    {
        int numberAccess;

        public AccessPanel(ECode codeInternal, EType typeDevice, double serialNumber, int numberAccess) : base(codeInternal, typeDevice, serialNumber)
        {
            NumberAccess = numberAccess;            
        }

        private int NumberAccess
        {
            set
            {
                if(value > 0 && value < 4)
                {
                    this.numberAccess = value;
                }else
                {
                    this.numberAccess = 1;
                }
            }
        } 

        protected override bool Test()
        {
            bool output = false;
            if(base.Test() && Components.Contains(EComponents.ModuleAccess))
            {
                
                output = true;
            }
            return output;
        }
    }
}
