using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Device
    {
        ECode codeInternal;
        EType typeDevice;
        double serialNumber;
        List<EComponents> components;

        /// <summary>
        /// Builder class Device.
        /// </summary>
        /// <param name="codeInternal"></param>
        /// <param name="typeDevice"></param>
        /// <param name="serialNumber"></param>
        protected Device(ECode codeInternal, EType typeDevice, double serialNumber)
        {
            this.codeInternal = codeInternal;
            this.typeDevice = typeDevice;
            this.serialNumber = serialNumber;
            this.components = new List<EComponents>();
        }

        public double SerialNumber
        {
            get
            {
                return this.serialNumber;
            }
        }

        public ECode CodeInternal
        {
            get
            {
                return this.codeInternal;
            }
        }
        public EType TypeDevice
        {
            get
            {
                return this.typeDevice;
            }
        }

        public List<EComponents> Components
        {
            get
            {
                return this.components;
            }
        }

        protected virtual bool Test()
        {
            bool output = false;

            if (Components.Contains(EComponents.Core) && Components.Contains(EComponents.Mother))
            {
                switch (typeDevice)
                {
                    case EType.FingerPrint:
                        if (Components.Contains(EComponents.FingerPrint))
                        {
                            output = true;
                        }
                            break;

                    case EType.Face:
                        if (Components.Contains(EComponents.FaceCamera))
                        {
                            output = true;
                        }
                        break;

                    case EType.Card:
                        if (Components.Contains(EComponents.ReadCard))
                        {
                            output = true;
                        }
                        break;
                }                
            }
            return output;
        }

        protected bool InstallOS()
        {
            bool output = false;
            if (Test() == true)
            {
                output = true;
            }
            return output;
        }

        public bool AddComponent(EComponents component)
        {
            bool output = false;
            if (Components.Count > 0 && !Components.Contains(component) || Components is null)
            {
                components.Add(component);
                output = true;
            }
            return output;
        }

        protected virtual string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Device {this.CodeInternal}");
            sb.AppendLine($"S/N: {this.SerialNumber}");
            return sb.ToString();
        }


    }
}
