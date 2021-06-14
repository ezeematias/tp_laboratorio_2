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

        /// <summary>
        /// Get and Sett Code Internal
        /// </summary>
        public ECode CodeInternal { get => this.codeInternal; set => this.codeInternal = value; }
        /// <summary>
        /// Get and Sett Type Device
        /// </summary>
        public EType TypeDevice { get => this.typeDevice; set => this.typeDevice = value; }
        /// <summary>
        /// Get and Sett Validation
        /// </summary>
        public EValidation EValidation { get => this.eValidation; set => this.eValidation = value; }
        /// <summary>
        /// Get and Sett SerialNumber
        /// </summary>
        public double SerialNumber { get => this.serialNumber; set => this.serialNumber = value; }
        /// <summary>
        /// Get and Sett the List Components
        /// </summary>
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

        /// <summary>
        /// Default builder to serialize
        /// </summary>
        public Device() { }

        /// <summary>
        /// Device builder.
        /// </summary>
        /// <param name="codeInternal">Code internal for the device</param>
        /// <param name="typeDevice">Type for the device</param>
        /// <param name="eValidation">Validation for the device</param>
        protected Device(ECode codeInternal, EType typeDevice, EValidation eValidation)
        {
            this.CodeInternal = codeInternal;
            this.TypeDevice = typeDevice;
            this.EValidation = eValidation;
            this.SerialNumber = SerialsNumbers.GetAndSetSerialNumber(typeDevice);
            this.components = new List<Components>();
        }

        /// <summary>
        /// Add a list of components depending on their validation type.
        /// </summary>
        /// <param name="eValidation">Validation for the device</param>
        protected abstract void AddComponent(EValidation eValidation);

        /// <summary>
        /// Generates the necessary information for a log
        /// </summary>
        /// <param name="type">Action type</param>
        /// <returns>An information string</returns>
        public virtual string View(string type)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Login.OperatorLog} {type} the device {this.CodeInternal} S/N: {this.SerialNumber} " + DateTime.Now.ToString());
            return sb.ToString();
        }

        /// <summary>
        /// Save in a file a log with date and time..
        /// </summary>
        /// <param name="device">The device to create the log.</param>
        /// <param name="type">The type of action</param>
        /// <returns>True or False depending on whether the file was recorded correctly.</returns>
        public static bool SaveLogDevices(Device device, string type)
        {
            try
            {
                return new Text().Save(@"\LogAssemblyDevices.txt", device.View(type));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Save in a file a log with date and time.
        /// </summary>
        /// <param name="data">Data for log</param>
        /// <returns></returns>
        public static bool SaveErrorLogDevices(string data)
        {            
            try
            {
                return new Text().Save(@"\LogErrorDevices.txt", data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Save in a file the operator report with the list of devices to load.
        /// </summary>
        /// <param name="devices"></param>
        /// <returns></returns>
        public static bool SaveReportsDevices(List<Device> devices)
        {
            try
            {
                return new Text().Save(@"\LogReportsDevices.txt", Device.Info(devices));                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ToString() overload to display information of the created device.
        /// </summary>
        /// <returns>A string with all the information.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n****************************\n");
            sb.AppendLine(String.Format(" {0,-10} {1,-20}","Code", this.CodeInternal));
            sb.AppendLine(String.Format(" {0,-10} {1,-20}", "Type", this.TypeDevice));
            sb.AppendLine(String.Format(" {0,-10} {1,-20}", "Validation",this.EValidation));
            sb.AppendLine(String.Format(" {0,-10} {1,-20}", "S/N",this.SerialNumber));           
            sb.AppendLine("\n----- Components -----------\n");
            foreach (Components item in Components)
            {
                sb.AppendLine(String.Format("   > {0,-11}  {1,-10}", item.NameComponent, item.CountComponent));              
            }
            sb.AppendLine("");
            return sb.ToString();
        }

        /// <summary>
        /// Operator report with the list of devices to load.
        /// </summary>
        /// <param name="devices"></param>
        /// <returns></returns>
        public static string Info(List<Device> devices)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXX\n");
            sb.AppendLine($" > {DateTime.Now}\n Work order Nº {CoreSystem.SelectedOrder.NumberOrder}\n -- Performed by -- \n {Login.OperatorLog}");            
            foreach (Device item in devices)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXX\n");
            return sb.ToString();
        }        
    }
}
