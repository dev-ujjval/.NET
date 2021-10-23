using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace CRUD
{
    public class CLASS_CONNECT
    {
        public SqlConnection con;
        public CLASS_CONNECT()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["CON_STR"].ConnectionString);
            con.Open();
        }
        
    }
}