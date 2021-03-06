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
    public class DataProvider
    {   
        private static DataProvider instance;
        private static OracleConnection connection;

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

        public static OracleConnection Connection { get => connection; set => connection = value; }

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

            if(connection != null)
            {
                OracleCommand command = new OracleCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains(':'))
                        {
                            command.Parameters.Add(new OracleParameter(item, parameter[i]));
                            i++;
                        }
                    }
                }

                OracleDataAdapter dataAdapter = new OracleDataAdapter(command);
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            return null;
        }

        public OracleCommand ExcuteNonQuery(string query, object[] parameter = null)
        {
            OracleCommand command;
            //int data = 0;

            if(connection != null)
            {
                command = new OracleCommand();
                command.Connection = connection;
                //command.CommandText += "EXEC proc_OracleScript; --\n";
                command.CommandText = query;

                command.CommandType = CommandType.Text;

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains(':'))
                        {
                            command.Parameters.Add(new OracleParameter(item, parameter[i]));
                            i++;
                        }
                    }
                }
                command.ExecuteNonQuery();
                return command;
            }
            
            return null;
        }
    }
}
