using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class AccessPanel : Device
    {      

        /// <summary>
        /// Default builder to serialize
        /// </summary>
        public AccessPanel() { }


        /// <summary>
        /// AccessPanel builder.
        /// </summary>
        /// <param name="codeInternal">Code internal for the device</param>
        /// <param name="typeDevice">Type for the device</param> 
        /// <param name="eValidation">Validation for the device</param>
        public AccessPanel(ECode codeInternal, EType typeDevice, EValidation eValidation) : base(codeInternal, typeDevice, eValidation)
        {            
            AddComponent(eValidation);
        }


        /// <summary>
        /// AccessPanel builder.
        /// </summary>
        /// <param name="serialNumber">Serial Number</param>
        /// <param name="codeInternal">Code internal for the device</param>
        /// <param name="typeDevice">Type for the device</param>
        /// <param name="eValidation">Validation for the device</param>
        public AccessPanel(double serialNumber, ECode codeInternal, EType typeDevice, EValidation eValidation) : base(serialNumber, codeInternal, typeDevice, eValidation)
        {           
            AddComponent(eValidation);
        }

        /// <summary>
        /// Add a list of components depending on their validation type.
        /// </summary>
        /// <param name="eValidation">Validation for the device</param>
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
