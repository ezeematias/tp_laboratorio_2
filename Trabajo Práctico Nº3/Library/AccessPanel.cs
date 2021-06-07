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

        public AccessPanel(ECode codeInternal, EType typeDevice, double serialNumber, int numberAccess, EValidation eValidation) : base(codeInternal, typeDevice, serialNumber)
        {
            NumberAccess = numberAccess;
            AddComponent(eValidation);
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

        protected override void AddComponent(EValidation eValidation)
        {
            if (eValidation == EValidation.Finger)
            {
                base.Components = CoreSystem.ComponentsPnlFinger;
            }
            else
            {
                base.Components = CoreSystem.ComponentsPnlRFID;
            }
        }
    }
}
