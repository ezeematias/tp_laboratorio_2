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
        public List<Components> Components { get => components; set => components = value; }

        /// <summary>
        /// Builder class Device.
        /// </summary>
        /// <param name="codeInternal"></param>
        /// <param name="typeDevice"></param>
        /// <param name="serialNumber"></param>
        protected Device(ECode codeInternal, EType typeDevice, double serialNumber = 0)
        {
            this.codeInternal = codeInternal;
            this.typeDevice = typeDevice;
            this.serialNumber = serialNumber;
            this.components = new List<Components>();
            LoadComponent();
        }

        private void LoadComponent()
        {
            bool aux = false;
            Components.Add(new Components(EComponents.Mother, 1));
            Components.Add(new Components(EComponents.Core, 1));
            Components.Add(new Components(EComponents.Package, 1));
            Components.Add(new Components(EComponents.Case, 1));
            Components.Add(new Components(EComponents.Display, 1));
            Components.Add(new Components(EComponents.Keyboard, 1));
            Components.Add(new Components(EComponents.Led, 10));
            Components.Add(new Components(EComponents.Sound, 2));

            for (int i = 0; i < 8; i++)
            {
                if (CoreSystem.ComponentsStock == Components[i])
                {
                    aux = true;
                }
                else
                {
                    aux = false;
                    break;
                }
            }
            if (aux)
            {
                for (int j = 0; j < 8; j++)
                {
                    aux = CoreSystem.ComponentsStock - Components[j];
                }
            }
        }

        protected abstract void AddComponent();

        protected virtual string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Device {this.CodeInternal}");
            sb.AppendLine($"S/N: {this.SerialNumber}");
            return sb.ToString();
        }

        /*
        protected bool InstallOS()
        {
            bool output = false;
            if (Test() == true)
            {
                output = true;
            }
            return output;
        }
        */

    }
}
