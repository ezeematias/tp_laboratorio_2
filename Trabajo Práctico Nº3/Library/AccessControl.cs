using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class AccessControl : Device
    {
        public AccessControl(ECode codeInternal, EType typeDevice, EValidation eValidation) : base(codeInternal, typeDevice, eValidation)
        {
            AddComponent(eValidation);
        }

        protected override void AddComponent(EValidation eValidation)
        {
            if (eValidation == EValidation.Finger)
            {
                base.Components = CoreSystem.ComponentsAccFinger;
            }
            else
            {
                base.Components = CoreSystem.ComponentsAccFace;
            }
        }
    }
}
