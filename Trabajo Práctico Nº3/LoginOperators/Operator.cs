using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.IO;
using Files;

namespace LoginOperators
{
    [Serializable]
    public class Operator 
    {
        private string name;
        private string lastName;
        private int userID;
        private int pass;

        public Operator()
        {

        }

        public Operator(string name, string lastName, int ID, int pass)
        {
            this.Name = name;
            this.LastName = lastName;
            this.UserID = ID;
            this.Pass = pass;
        }

        public string Name { get => this.name; set => this.name = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public int UserID { get => this.userID; set => this.userID = value; }
        public int Pass { get => this.pass; set => this.pass = value; }

        public static void ReadOperator()
        {
            try
            {
                List<Operator> aux = new List<Operator>();
                if (new Xml<List<Operator>>().Read("Operators.xml", out aux))
                {
                    Login.Operators = aux;
                }                
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool SaveOperator()
        {
            try
            {   
                if (new Xml<List<Operator>>().Save("Operators.xml", Login.Operators))
                {
                    return true;
                }
                return false;
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new FileNotFoundException(ex.ToString());
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Operator: {this.Name} {this.LastName}");
            return sb.ToString();
        }
    }
}
