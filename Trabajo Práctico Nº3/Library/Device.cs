using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;
using Files;
using LoginOperators;

namespace Library
{
    [Serializable]
    [XmlInclude(typeof(AccessControl))]
    [XmlInclude(typeof(AccessPanel))]
    [XmlInclude(typeof(Attendance))]
    public abstract class Device
    {
        ECode codeInternal;
        EType typeDevice;
        EValidation eValidation;
        double serialNumber;
        List<Components> components;

        public ECode CodeInternal { get => this.codeInternal; set => this.codeInternal = value; }
        public EType TypeDevice { get => this.typeDevice; set => this.typeDevice = value; }
        public EValidation EValidation { get => this.eValidation; set => this.eValidation = value; }
        public double SerialNumber { get => this.serialNumber; set => this.serialNumber = value; }

        public List<Components> Components
        {
            get => this.components;
            set
            {
                if (Stock.ChargedComponent(value))
                {
                    this.components = value;
                }
            }
        }

        public Device() { }        
        
        protected Device(ECode codeInternal, EType typeDevice, EValidation eValidation)
        {
            this.CodeInternal = codeInternal;
            this.TypeDevice = typeDevice;
            this.EValidation = eValidation;
            this.SerialNumber = SerialsNumbers.GetAndSetSerialNumber(typeDevice);
            this.components = new List<Components>();
        }

        protected abstract void AddComponent(EValidation eValidation);     

        public virtual string View(string type)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Login.OperatorLog} {type} the device {this.CodeInternal} S/N: {this.SerialNumber} " + DateTime.Now.ToString());
            return sb.ToString();
        }
        
        public static bool SaveLogDevices(Device device, string type)
        {
            try
            {
                return (new Text().Save("LogAssemblyDevices.txt", device.View(type)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
