using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginOperators
{
    [Serializable]
    public static class Login
    {
        private static Operator operatorLog;
        private static List<Operator> operators;

        /// <summary>
        /// Get and Set Operators
        /// </summary>
        public static List<Operator> Operators { get => operators; set => operators = value; }

        /// <summary>
        /// Get and Set OperatorLog
        /// </summary>
        public static Operator OperatorLog { get => operatorLog; set => operatorLog = value; }

        public static bool LogIn(int user, int pass)
        {
            foreach (Operator op in Login.Operators)
            {
                if (op.UserID == user && op.Pass == pass)
                {
                    OperatorLog = op;                    
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Load Administrator
        /// </summary>
        public static void LoadAdministrator()
        {
            Operators = new List<Operator>();
            Operators.Add(new Operator("Admin", "", 1000, 1000));
        }

        /// <summary>
        /// Displays the operator information.
        /// </summary>
        /// <returns>String with the operator data</returns>
        public static string View()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Operator item in Operators)
            {
                sb.AppendLine($"{item.Name} {item.LastName}");
                sb.AppendLine($" - User: {item.UserID} and Pass: {item.Pass}");
                sb.AppendLine("");
            }    
            return sb.ToString();
        }
    }
}
