using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class D_Connection
    {
        private SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=DB_WEBFORM;Integrated Security=True;");
        
        public SqlConnection Connection
        {
            get { return cn; }
        }
    }


}
