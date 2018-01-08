using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;

namespace VendorTable.Models
{
    public class Vendors : CalvinDb
    {
        //================  PROPERTIES  ================================
        private string vendor_id;
        private string vendor_name;
        private string vendor_address1;
        private string vendor_address2;
        private string vendor_city;
        private string vendor_state;
        private string vendor_zip_code;
        private string vendor_phone;
        private string vendor_contact_l_name;
        private string vendor_contact_f_name;
        private string default_terms_id;
        private string default_account_number;

        //=================  FIELDS  ====================================
            //public fields

        public string Vendor_Id { get { return vendor_id; } }
        public string Vendor_Name { get { return vendor_name; } }
        public string Vendor_Address_1 { get { return vendor_address1; } }
        public string Vendor_Address_2 { get { return vendor_address2; } }
        public string Vendor_City { get { return vendor_city; } }
        public string Vendor_State { get { return vendor_city; } }
        public string Vendor_Zip_Code { get { return vendor_zip_code; } }
        public string Vendor_Phone { get { return vendor_phone; } }
        public string Vendor_Contact_lname { get { return vendor_contact_l_name; } }
        public string Vendor_Contact_fname { get { return vendor_contact_f_name; } }
        public string Default_Terms_Id { get { return default_terms_id; } }
        public string Default_Account_Number { get { return default_account_number; } }

            //private fields

        protected List<Vendors> vendors = new List<Vendors>();
        //line 44 was added by visual studios and isn't in Lee's work.. beware...

        //=============== METHODS =====================================

        // = = = = = = Public List READ= = = = = = = = = //
        //this list will cover the READ of CRUD

        public List<Vendors> GetAll()
        {
            string query = "SELECT * FROM vendors ORDER BY vendor_id";
            vendors.Clear();

            OracleConnection conn = new OracleConnection(connectionString);

            try
            {
                conn.Open();
                cmd = new OracleCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Vendors thisVendor = new Vendors();
                    thisVendor.vendor_id = reader["vendor_id"].ToString();
                    thisVendor.vendor_name = reader["vendor_name"].ToString();
                    thisVendor.vendor_address1 = reader["vendor_address1"].ToString();
                    thisVendor.vendor_address2 = reader["vendor_address2"].ToString();
                    thisVendor.vendor_city = reader["vendor_city"].ToString();
                    thisVendor.vendor_state = reader["vendor_state"].ToString();
                    thisVendor.vendor_zip_code = reader["vendor_zip_code"].ToString();
                    thisVendor.vendor_phone = reader["vendor_phone"].ToString();
                    thisVendor.vendor_contact_l_name = reader["vendor_contact_last_name"].ToString();
                    thisVendor.vendor_contact_f_name = reader["vendor_contact_first_name"].ToString();
                    thisVendor.default_terms_id = reader["default_terms_id"].ToString();
                    thisVendor.default_account_number = reader["default_account_number"].ToString();

                    vendors.Add(thisVendor);
                }  //end of while function
            
                reader.Close();
                conn.Close();
            }  //end of try function

            catch (OracleException exc)
            {
                Vendors exceptionTerm = new Vendors
                {
                    vendor_id = exc.ToString(),
                    vendor_name = exc.ToString(),
                    vendor_address1 = exc.ToString(),
                    vendor_address2 = exc.ToString(),
                    vendor_city = exc.ToString(),
                    vendor_state = exc.ToString(),
                    vendor_zip_code = exc.ToString(),
                    vendor_phone = exc.ToString(),
                    vendor_contact_l_name = exc.ToString(),
                    vendor_contact_f_name = exc.ToString(),
                    default_terms_id = exc.ToString(),
                    default_account_number = exc.ToString(),
                };  //end of exception term
            } // end of catch function


            return vendors;

        } // end of List

          // = = = = = = = Public Boolean ADD = = = = = = = = = = = =//
          //this public boolean variable will cover the CREATE of CRUD 

        //public bool Add(string id,
        //                string name,
        //                string address1,
        //                string address2,
        //                string city,
        //                string state,
        //                string zipcode,
        //                string phone,
        //                string lastname,
        //                string firstname,
        //                string termsid,
        //                string accountnumber)
        //{

        //    string command = "INSERT INTO vendors (vendor_id, vendor_name, vendor_address1, vendor_address2, vendor_city, vendor_state, vendor_zip_code, vendor_phone, vendor_contact_last_name, vendor_contact_first_name, default_terms_id, default_account_number"
        //        + "VALUES (:Id, :Name, : Address1, :Address2, :City, :State, :Zipcode, :Phone, :Lastname, :Firstname, :Termsid, :Accountnumber)";

        //    OracleConnection conn = new OracleConnection(connectionString);

        //    try
        //    {
        //        conn.Open();
        //        cmd = new OracleCommand(command, conn);
        //        cmd.Parameters.Add(new OracleParameter("Id", id));
        //        cmd.Parameters.Add(new OracleParameter("Name", name));
        //        cmd.Parameters.Add(new OracleParameter("Address1", address1));
        //        cmd.Parameters.Add(new OracleParameter("Address2", address2));
        //        cmd.Parameters.Add(new OracleParameter("City", city));
        //        cmd.Parameters.Add(new OracleParameter("State", state));
        //        cmd.Parameters.Add(new OracleParameter("Zipcode", zipcode));
        //        cmd.Parameters.Add(new OracleParameter("Phone", phone));
        //        cmd.Parameters.Add(new OracleParameter("Lastname", lastname));
        //        cmd.Parameters.Add(new OracleParameter("Firstname", firstname));
        //        cmd.Parameters.Add(new OracleParameter("Termsid", termsid));
        //        cmd.Parameters.Add(new OracleParameter("Accountnumber", accountnumber));

        //        int rowsAdded = cmd.ExecuteNonQuery();
        //        conn.Close();
        //        return true;
        //    } 

        //    catch(OracleException ex)
        //    {
        //        return false;
        //    }

        //} // end of Add

        //= = = = = = = = Public String UPDATE = = = = = = = = = = = =//
        //this public string variable will cover the UPDATE of CRUD

        //public string Update(string id,
        //                string name,
        //                string address1,
        //                string address2,
        //                string city,
        //                string state,
        //                string zipcode,
        //                string phone,
        //                string lastname,
        //                string firstname,
        //                string termsid,
        //                string accountnumber)
        //{
        //    string command = "UPDATE vendors SET vendor_name = :vname, vendor_address1 = :vadd1, vendor_address2 = :vadd2, vendor_city = :vcity, vendor_state = :vstate, vendor_zip_code = :vzipcode, vendor_phone = :vphone, vendor_contact_last_name = :vlastname, vendor_contact_first_name = :vfirstname, default_terms_id = :dTermsId, default_account_number = :dAccNum  WHERE vendor_id = :vID";
        //    OracleConnection conn = new OracleConnection(connectionString);

        //    try
        //    {
        //        conn.Open();
        //        var transaction = conn.BeginTransaction();

        //        cmd = new OracleCommand(command, conn);
        //        cmd.Parameters.Add(new OracleParameter("vID", id));
        //        cmd.Parameters.Add(new OracleParameter("vname", name));
        //        cmd.Parameters.Add(new OracleParameter("vadd1", address1));
        //        cmd.Parameters.Add(new OracleParameter("vadd2", address2));
        //        cmd.Parameters.Add(new OracleParameter("vcity", city));
        //        cmd.Parameters.Add(new OracleParameter("vstate", state));
        //        cmd.Parameters.Add(new OracleParameter("vzipcode", zipcode));
        //        cmd.Parameters.Add(new OracleParameter("vphone", phone));
        //        cmd.Parameters.Add(new OracleParameter("vlastname", lastname));
        //        cmd.Parameters.Add(new OracleParameter("vfirstname", firstname));
        //        cmd.Parameters.Add(new OracleParameter("dTermsId", termsid));
        //        cmd.Parameters.Add(new OracleParameter("dAccNum", accountnumber));
        //        cmd.Prepare();

        //        cmd.Transaction = transaction;
        //        cmd.ExecuteNonQuery();
        //        transaction.Commit();
        //        cmd.Dispose();

        //        conn.Close();
        //        return "success";
        //    }

        //    catch(OracleException exception)
        //    {
        //        return exception.ToString();
        //    }
        //} //end of Update

        //= = = = = = = = Public Bool DELETE = = = = = = = = = = = =//
        //this public bool variable will cover the DELETE of CRUD

        //public bool Delete(string id)
        //{
        //    string command = "DELETE FROM vendors WHERE vendor_id = :v";

        //    OracleConnection conn = new OracleConnection(connectionString);

        //    try
        //    {
        //        conn.Open();
        //        cmd = new OracleCommand(command, conn);
        //        cmd.Parameters.Add(new OracleParameter("vID", id));

        //        cmd.ExecuteNonQuery();
        //        conn.Close();
        //        return true;
        //    }

        //    catch(OracleException ex)
        //    {
        //        return false;
        //    }
        //} //end of delete



    } // end of Vendors : CalvinDb public class
} // end of VendorTable.Models namespace