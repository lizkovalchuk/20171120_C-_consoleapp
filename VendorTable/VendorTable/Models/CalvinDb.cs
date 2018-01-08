using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using CalvinDb.Models;

namespace VendorTable.Models
{
    public class CalvinDb
    {
        //Feilds
        private static string host = "calvin.humber.ca";
        private static string port = "1521";
        private static string sid = "grok";
        private static string username = OracleLogin.username;
        private static string password = OracleLogin.password;

        public static string connectionString { get { return OracleConnString(host, port, sid, username, password); } }
        public OracleConnection conn = new OracleConnection(connectionString);

        protected OracleConnection myConnection { get { return new OracleConnection(connectionString); } }



        protected OracleCommand cmd;
        protected OracleDataReader reader;


        //public static string connectionString = OracleConnString(host, port, sid, username, password);        
        //private string _message; //this line of code may be unneccesary 



        


        //Method From Chris Hulbert
        private static string OracleConnString(string host, string port, string servicename, string user, string pass)
        {
            return String.Format(
              "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})" +
              "(PORT={1}))(CONNECT_DATA=(SERVICE_NAME={2})));User Id={3};Password={4};",
              host,
              port,
              servicename,
              user,
              pass);
        }


    } // end of CalvinDb public class
} // end of Vendortable.Models namespace