using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public sealed class Attendance : Device
    {
        public Attendance()
        {

        }

        public Attendance(ECode codeInternal, EType typeDevice, EValidation eValidation) : base(codeInternal, typeDevice, eValidation)
        {
            AddComponent(eValidation);
        }
        
        protected override void AddComponent(EValidation eValidation)
        {
            if(eValidation == EValidation.Finger)
            {
                base.Components = CoreSystem.ComponentsAttFinger;
            }
            else
            {
                base.Components = CoreSystem.ComponentsAttFace;
            }            
        }   
    }
}
