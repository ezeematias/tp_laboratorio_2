using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public sealed class Attendance : Device
    {
        /// <summary>
        /// Default builder to serialize
        /// </summary>
        public Attendance() { }

        /// <summary>
        /// Attendance builder.
        /// </summary>
        /// <param name="codeInternal">Code internal for the device</param>
        /// <param name="typeDevice">Type for the device</param>
        /// <param name="eValidation">Validation for the device</param>
        public Attendance(ECode codeInternal, EType typeDevice, EValidation eValidation) : base(codeInternal, typeDevice, eValidation)
        {
            AddComponent(eValidation);
        }

        /// <summary>
        /// Add a list of components depending on their validation type.
        /// </summary>
        /// <param name="eValidation">Validation for the device</param>
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
