using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Operator
    {
        private string name;
        private string lastName;
        private int userID;
        private int pass;
        private List<Device> devices;

        public Operator(string name, string lastName, int ID, int pass)
        {
            this.name = name;
            this.devices = new List<Device>();
            this.lastName = lastName;
            this.userID = ID;
            this.pass = pass;
        }

        public List<Device> Devices { get { return devices; } }
        public int UserID { get { return userID; } }
        public int Pass { get { return pass; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Operator: {this.name} {this.lastName}");
            return sb.ToString();
        }

        public static bool operator + (Operator o, Device d)
        {
            bool output = false;
            if(!(o is null && d is null))
            {
                o.devices.Add(d);
                output = true;
            }
            return output;
        }

    }
}
