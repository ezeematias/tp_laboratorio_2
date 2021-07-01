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

        /// <summary>
        /// Default builder to serialize
        /// </summary>
        public AccessPanel() { }


        /// <summary>
        /// AccessPanel builder.
        /// </summary>
        /// <param name="codeInternal">Code internal for the device</param>
        /// <param name="typeDevice">Type for the device</param>
        /// <param name="numberAccess">Number the access for device</param>
        /// <param name="eValidation">Validation for the device</param>
        public AccessPanel(ECode codeInternal, EType typeDevice, int numberAccess, EValidation eValidation) : base(codeInternal, typeDevice, eValidation)
        {
            NumberAccess = numberAccess;
            AddComponent(eValidation);
        }

        /// <summary>
        /// Get and Sett Number Access
        /// </summary>
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
