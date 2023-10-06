using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DAO
{
    class accountDAO
    {
        private static accountDAO instance;

        internal static accountDAO Instance 
        {
            get { if (instance == null) instance = new accountDAO(); return instance; }
            private set { instance = value; }

        }

        private accountDAO() { }

        public bool login(string userName, string passWord)
        {
            string query = string.Format("Exec dbo.CHECKACC @mk = '{0}', @dn = '{1}'", userName, passWord);

            DataTable Dt = DataProvider.Instance.ExecuteQuery(query);
            
            return Dt.Rows.Count > 0;
        }
    }
}
