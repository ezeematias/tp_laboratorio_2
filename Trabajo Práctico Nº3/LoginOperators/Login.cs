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

        public static List<Operator> Operators { get => operators; set => operators = value; }
        public static Operator OperatorLog { get => operatorLog; set => operatorLog = value; }

        public static void LoadAdministrator()
        {
            Operators = new List<Operator>();
            Operators.Add(new Operator("Admin", "", 1000, 1000));
        }

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
