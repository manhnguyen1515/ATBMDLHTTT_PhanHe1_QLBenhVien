using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1.DAO
{
    class DataProvider
    {
        //private string connectionStr = "DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\\Users\\manhn\\Oracle\\network\\admin;USER ID=SYS;DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True";
        //private string connectionStr = "TNS_ADMIN=C:\\Users\\manhn\\Oracle\\network\\admin;USER ID=SYSTEM;DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True";
        
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public OracleConnection GetDBConnection(string host, int port, String sid, String user, String password)
        {

            //Console.WriteLine("Getting Connection ...");

            // 'Connection String' kết nối trực tiếp tới Oracle.
            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;


            OracleConnection conn = new OracleConnection();

            conn.ConnectionString = connString;

            return conn;
        }

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable dataTable = new DataTable();

            using (OracleConnection connection = GetDBConnection("localhost", 1521, "xe", "ADMIN", "thaosuong"))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.Add(item, parameter[i]);
                            i++;
                        }
                    }
                }

                OracleDataAdapter dataAdapter = new OracleDataAdapter(command);
                dataAdapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }

        public OracleCommand ExcuteNonQuery(string query, object[] parameter = null)
        {
            OracleCommand command;
            using (OracleConnection connection = GetDBConnection("localhost", 1521, "xe", "ADMIN", "thaosuong"))
            {
                connection.Open();
                command = new OracleCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.Add(item, parameter[i]);
                            i++;
                        }
                    }
                }
                command.ExecuteNonQuery();
                connection.Close();
            }
            return command;
        }

        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = null;

            using (OracleConnection connection = GetDBConnection("localhost", 1521, "xe", "ADMIN", "thaosuong"))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.Add(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
