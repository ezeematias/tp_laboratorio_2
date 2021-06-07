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
        List<Components> components;

        public ECode CodeInternal { get => codeInternal; set => codeInternal = value; }
        public EType TypeDevice { get => typeDevice; set => typeDevice = value; }
        public double SerialNumber { get => serialNumber; set => serialNumber = value; }
        public List<Components> Components
        {
            get => components;
            set
            {
                if (Stock.ChargedComponent(value))
                {
                    components = value;
                }
            }
        }
 
        protected Device(ECode codeInternal, EType typeDevice, double serialNumber)
        {
            this.CodeInternal = codeInternal;
            this.TypeDevice = typeDevice;
            this.SerialNumber = serialNumber;
            this.components = new List<Components>();
        }

        protected abstract void AddComponent(EValidation eValidation);     

        protected virtual string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Device {this.CodeInternal}");
            sb.AppendLine($"S/N: {this.SerialNumber}");
            return sb.ToString();
        }
    }
}
