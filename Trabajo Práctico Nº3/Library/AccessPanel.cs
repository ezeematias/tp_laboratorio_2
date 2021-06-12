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

        public AccessPanel()
        {

        }

        public AccessPanel(ECode codeInternal, EType typeDevice, int numberAccess, EValidation eValidation) : base(codeInternal, typeDevice, eValidation)
        {
            NumberAccess = numberAccess;
            AddComponent(eValidation);
        }

        public int NumberAccess
        {
            get => this.numberAccess;
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
