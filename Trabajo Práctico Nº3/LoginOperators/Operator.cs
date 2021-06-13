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

        /// <summary>
        /// Default builder to serialize
        /// </summary>
        public Operator() { }

        /// <summary>
        /// Builder Operator
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="lastName">Last Name</param>
        /// <param name="ID">User ID</param>
        /// <param name="pass">User Password</param>
        public Operator(string name, string lastName, int ID, int pass)
        {
            this.Name = name;
            this.LastName = lastName;
            this.UserID = ID;
            this.Pass = pass;
        }

        /// <summary>
        /// Get and Set Name
        /// </summary>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// Get and Set LastName
        /// </summary>
        public string LastName { get => this.lastName; set => this.lastName = value; }

        /// <summary> 
        /// Get and Set UserID
        /// </summary>
        public int UserID { get => this.userID; set => this.userID = value; }

        /// <summary>
        /// Get and Set Pass
        /// </summary>
        public int Pass { get => this.pass; set => this.pass = value; }

        /// <summary>
        /// Read the file with the Operators and set them.
        /// </summary>
        public static void ReadOperator()
        {
            try
            {
                List<Operator> aux = new List<Operator>();
                if (new Xml<List<Operator>>().Read(@"\Operators.xml", out aux))
                {
                    Login.Operators = aux;
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Save the Operators to a file.
        /// </summary>
        /// <returns>True or false</returns>
        public static bool SaveOperator()
        {
            try
            {   
                if (new Xml<List<Operator>>().Save(@"\Operators.xml", Login.Operators))
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

        /// <summary>
        /// ToString() overload to display information of the created operator.
        /// </summary>
        /// <returns>A string with all the information.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Operator: {this.Name} {this.LastName}");
            return sb.ToString();
        }
    }
}
