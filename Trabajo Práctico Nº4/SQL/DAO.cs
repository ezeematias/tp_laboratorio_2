using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Library;

namespace SQL
{
    public static class DAO
    {
        static string connectionStr = "Server = .; Database = Connected_db; Trusted_Connection = true;";
        //TODO: Comentar todos los métodos - DAO
        public static void SaveDevice(List<Device> devices)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    connection.Open();
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandText = "INSERT INTO stockDevice VALUES (@serialNumber, @codeInternal, @typeDevice, @eValidation)";
                    foreach (Device item in devices)
                    {
                        sqlCommand.Parameters.AddWithValue("@serialNumber", (long)item.SerialNumber);
                        sqlCommand.Parameters.AddWithValue("@codeInternal", item.CodeInternal.ToString());
                        sqlCommand.Parameters.AddWithValue("@typeDevice", item.TypeDevice.ToString());
                        sqlCommand.Parameters.AddWithValue("@eValidation", item.EValidation.ToString());
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Parameters.Clear();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("The list of devices could not be saved in the database.");
            }
        }

        public static List<Device> LoadDevice()
        {
            List<Device> devices = new List<Device>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandText = "SELECT * FROM stockDevice";
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read() != false)
                        {
                            Enum.TryParse(dataReader["codeInternal"].ToString(), out ECode eCode);
                            Enum.TryParse(dataReader["typeDevice"].ToString(), out EType eType);
                            Enum.TryParse(dataReader["eValidation"].ToString(), out EValidation eValidation);
                            switch (eType)
                            {
                                case EType.AccessControl:
                                    devices.Add(new AccessControl(Convert.ToDouble(dataReader["serialNumber"]), eCode, eType, eValidation));
                                    break;
                                case EType.PanelAccess:
                                    devices.Add(new AccessPanel(Convert.ToDouble(dataReader["serialNumber"]), eCode, eType, eValidation));
                                    break;
                                case EType.Attendance:
                                    devices.Add(new Attendance(Convert.ToDouble(dataReader["serialNumber"]), eCode, eType, eValidation));
                                    break;
                            }
                        }
                    }
                    return devices;
                }
            }
            catch (Exception)
            {
                throw new Exception("The device list was not found in the database.");
            }
        }

        public static void SaveComponents(List<Components> components)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    connection.Open();
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandText = "INSERT INTO stockComponent VALUES (@name, @count)";
                    foreach (Components item in components)
                    {
                        sqlCommand.Parameters.AddWithValue("@name", item.NameComponent.ToString());
                        sqlCommand.Parameters.AddWithValue("@count", item.CountComponent);
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Parameters.Clear();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("The list of components could not be saved in the database.");
            }
        }

        public static List<Components> LoadComponent()
        {
            List<Components> components = new List<Components>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandText = "SELECT * FROM stockComponent";
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read() != false)
                        {
                            Enum.TryParse(dataReader["name"].ToString(), out EComponents eComponents);
                            components.Add(new Components(eComponents, Convert.ToInt32(dataReader["count"])));
                        }
                    }
                    return components;
                }
            }
            catch (Exception)
            {
                throw new Exception("The components list was not found in the database.");
            }
        }

        public static bool ModifyComponent(Components components)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandText = $"UPDATE stockComponent SET count=@count WHERE name=@name";
                    sqlCommand.Parameters.AddWithValue("@name", components.NameComponent.ToString());
                    sqlCommand.Parameters.AddWithValue("@count", components.CountComponent);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new Exception("The components was not found in the database.");
            }
        }

        public static bool ModifyListComponents(List<Components> components)
        {
            try
            {
                foreach (Components item in components)
                {
                    DAO.ModifyComponent(item);
                }
                return true;

            }
            catch (Exception)
            {
                throw new Exception("The components list was not found in the database.");
            }
        }





    }
}
