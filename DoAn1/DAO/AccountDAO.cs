using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        public bool Login(string userName, string passWord)
        {
            string query = "BEGIN check_password( :userName , :passWord ) END;";
            OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { userName, passWord });

            return cmd.RowSize > 0;
        }
    }
}
