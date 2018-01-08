using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VendorTable.Models;
using Oracle.ManagedDataAccess.Client;

namespace VendorTable
{

    // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
    //===============================READ OF CRUD============================================
    // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =

    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = VendorTable.Models.CalvinDb.connectionString;

            conn.Open();
            OracleCommand cmd = new OracleCommand("SELECT * FROM vendors ORDER BY vendor_id", conn);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ul_vendor_id.InnerHtml += "<li>" + reader["vendor_id"].ToString() + "</li>";
                ul_vname.InnerHtml += "<li>" + reader["vendor_name"].ToString() + "</li>";
                ul_v_address1.InnerHtml += "<li>" + reader["vendor_address1"].ToString() + "</li>";
                ul_v_address2.InnerHtml += "<li>" + reader["vendor_address2"].ToString() + "</li>";
                ul_vendor_city.InnerHtml += "<li>" + reader["vendor_city"].ToString() + "</li>";
                ul_vendor_state.InnerHtml += "<li>" + reader["vendor_state"].ToString() + "</li>";
                ul_vendor_zip_code.InnerHtml += "<li>" + reader["vendor_zip_code"].ToString() + "</li>";
            }

            conn.Close();
            drpdwn_drpdwn_v_id_load();
        } //end of Page_Load protected void


        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        //===============================CREATE OF CRUD============================================
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =

        protected void btn_add_vendor_Click(object sender, EventArgs e)
        {
            //take user input and store in variables
            int vendor_id = Convert.ToInt32(txtbox_add_vendor_id.Text);
            string vendor_name = txtbox_add_vendor_name.Text;
            string vendor_add1 = txtbox_add_vendor_address1.Text;
            string vendor_add2 = txtbox_add_vendor_address2.Text;
            string vendor_city = txtbox_add_vendor_city.Text;
            string vendor_state = txtbox_add_vendor_state.Text;
            string vendor_zipcode = txtbox_add_vendor_zipcode.Text;
            string vendor_phone = null;
            string vendor_contact_lname = null;
            string vendor_contact_fname = null;
            int default_terms_id = 81;
            int default_account_number = 100;

            //create variable to count # of Non Queries Executed
            int rows = 0;
            try
            {
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = VendorTable.Models.CalvinDb.connectionString;
                conn.Open();
                
                string command = "INSERT INTO vendors VALUES(:id, :vname, :vadd1, :vadd2, :vcity, :vstate, :vzipcode, :vphone, :vcontact_lname, :vcontact_fname, :defterms_id, :defacc_num)";

                OracleCommand cmd = new OracleCommand(command, conn);
                cmd.Parameters.Add(new OracleParameter("id", vendor_id));
                cmd.Parameters.Add(new OracleParameter("vname", vendor_name));
                cmd.Parameters.Add(new OracleParameter("vadd1", vendor_add1));
                cmd.Parameters.Add(new OracleParameter("vadd2", vendor_add2));
                cmd.Parameters.Add(new OracleParameter("vcity", vendor_city));
                cmd.Parameters.Add(new OracleParameter("vstate", vendor_state));
                cmd.Parameters.Add(new OracleParameter("vzipcode", vendor_zipcode));
                cmd.Parameters.Add(new OracleParameter("vphone", vendor_phone));
                cmd.Parameters.Add(new OracleParameter("vcontact_lname", vendor_contact_lname));
                cmd.Parameters.Add(new OracleParameter("vcontact_fname", vendor_contact_fname));
                cmd.Parameters.Add(new OracleParameter("defterms_id", default_terms_id));
                cmd.Parameters.Add(new OracleParameter("defacc_num", default_account_number));

                rows = cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (OracleException excep)
            {
                lbl_oracle_message.Text = excep.Message;
                if (excep.Message.Contains("ORA-02291"))
                {
                    lbl_oracle_message.Text = "This default terms ID or default account already exists." + "<br/>" + "Please enter different numbers";
                }
            }
            finally
            {
                lbl_oracle_message.Text += "<br/> " + Convert.ToString(rows) + " rows affected" + "<br/>";
            }
        } //end of Add Vendor button

        protected void btn_refresh1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = VendorTable.Models.CalvinDb.connectionString;

            conn.Open();
            OracleCommand cmd = new OracleCommand("SELECT * FROM vendors ORDER BY vendor_id", conn);
            OracleDataReader reader = cmd.ExecuteReader();

            ul_vendor_id.InnerHtml = "";
            ul_vname.InnerHtml = "";
            ul_v_address1.InnerHtml = "";
            ul_v_address2.InnerHtml = "";
            ul_vendor_city.InnerHtml = "";
            ul_vendor_state.InnerHtml = "";
            ul_vendor_zip_code.InnerHtml = "";

            while (reader.Read())
            {
                ul_vendor_id.InnerHtml += "<li>" + reader["vendor_id"].ToString() + "</li>";
                ul_vname.InnerHtml += "<li>" + reader["vendor_name"].ToString() + "</li>";
                ul_v_address1.InnerHtml += "<li>" + reader["vendor_address1"].ToString() + "</li>";
                ul_v_address2.InnerHtml += "<li>" + reader["vendor_address2"].ToString() + "</li>";
                ul_vendor_city.InnerHtml += "<li>" + reader["vendor_city"].ToString() + "</li>";
                ul_vendor_state.InnerHtml += "<li>" + reader["vendor_state"].ToString() + "</li>";
                ul_vendor_zip_code.InnerHtml += "<li>" + reader["vendor_zip_code"].ToString() + "</li>";


            }

            conn.Close();
            drpdwn_drpdwn_v_id_load();
        } //end of btn_refresh1_Click


        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        //===============================UPDATE OF CRUD============================================
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =


        //-------------------------------------------------------------------------------------
        //code for dynamic dropdown menu
        protected void drpdwn_drpdwn_v_id_load()
        {
            OracleConnection conn = new OracleConnection();
            OracleCommand cmd = new OracleCommand("SELECT * FROM vendors ORDER BY vendor_id", conn);
            conn.ConnectionString = VendorTable.Models.CalvinDb.connectionString;

            conn.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string vendor_id = reader["vendor_id"].ToString();
                ListItem vendorIDs = new ListItem(vendor_id);
                drpdwn_v_id.Items.Add(vendorIDs);
                drpdwn_v_id_delete.Items.Add(vendorIDs);
               // drpdwn_result1.Text = drpdwn_v_id.SelectedValue;
            }
            conn.Close();
        }
        //-------------------------------------------------------------------------------------------

        protected void btn_up_vendor_Click(object sender, EventArgs e)
        {

            //take user input and store in variables
            int vendor_id = Convert.ToInt32(drpdwn_v_id.SelectedValue);
            string vendor_name = txtbox_up_vendor_name.Text;
            string vendor_add1 = txtbox_up_vendor_address1.Text;
            string vendor_add2 = txtbox_up_vendor_address2.Text;
            string vendor_city = txtbox_up_vendor_city.Text;
            string vendor_state = txtbox_up_state_state.Text;
            string vendor_zipcode = txtbox_v_zipcode_up.Text;
            string vendor_phone = null;
            string vendor_contact_lname = null;
            string vendor_contact_fname = null;
            int default_terms_id = 81;
            int default_account_number = 100;

            if (vendor_name == "" || vendor_city == "" || vendor_state == "" || vendor_zipcode == "" )
            {
                lbl_contraints.Text = "Vendor name, city, state and zipcode cannot be left blank";
            } // end of embedding if statement

            else
            {
                int rows = 0;
                try
                {
                    OracleConnection conn = new OracleConnection();
                    conn.ConnectionString = VendorTable.Models.CalvinDb.connectionString;
                    conn.Open();

                    string command = "UPDATE vendors SET vendor_id = :id, vendor_name = :vname, vendor_address1 = :vadd1, vendor_address2 = :vadd2, vendor_city = :vcity, vendor_state = :vstate, vendor_zip_code = :vzipcode, vendor_phone = :vphone, vendor_contact_last_name = :vcontact_lname, vendor_contact_first_name = :vcontact_fname, default_terms_id = :defterms_id, default_account_number = :defacc_num WHERE vendor_id =:id ";

                    OracleCommand cmd = new OracleCommand(command, conn);
                    cmd.Parameters.Add(new OracleParameter("id", vendor_id));
                    cmd.Parameters.Add(new OracleParameter("vname", vendor_name));
                    cmd.Parameters.Add(new OracleParameter("vadd1", vendor_add1));
                    cmd.Parameters.Add(new OracleParameter("vadd2", vendor_add2));
                    cmd.Parameters.Add(new OracleParameter("vcity", vendor_city));
                    cmd.Parameters.Add(new OracleParameter("vstate", vendor_state));
                    cmd.Parameters.Add(new OracleParameter("vzipcode", vendor_zipcode));
                    cmd.Parameters.Add(new OracleParameter("vphone", vendor_phone));
                    cmd.Parameters.Add(new OracleParameter("vcontact_lname", vendor_contact_lname));
                    cmd.Parameters.Add(new OracleParameter("vcontact_fname", vendor_contact_fname));
                    cmd.Parameters.Add(new OracleParameter("defterms_id", default_terms_id));
                    cmd.Parameters.Add(new OracleParameter("defacc_num", default_account_number));

                    rows = cmd.ExecuteNonQuery();

                    conn.Close();
                }
                catch (OracleException excep)
                {
                    lbl_oracle_message.Text = excep.Message;
                    if (excep.Message.Contains("ORA-02291"))
                    {
                        lbl_oracle_message.Text = "This default terms ID or default account already exists." + "<br/>" + "Please enter different numbers";
                    }
                }
                finally
                {
                    lbl_oracle_message.Text += "<br/> " + Convert.ToString(rows) + " rows affected" + "<br/>";
                }
            } //end of else
            drpdwn_drpdwn_v_id_load();
        } //end of Update Vendor Info button

        protected void btn_refresh2_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = VendorTable.Models.CalvinDb.connectionString;

            conn.Open();
            OracleCommand cmd = new OracleCommand("SELECT * FROM vendors ORDER BY vendor_id", conn);
            OracleDataReader reader = cmd.ExecuteReader();

            ul_vendor_id.InnerHtml = "";
            ul_vname.InnerHtml = "";
            ul_v_address1.InnerHtml = "";
            ul_v_address2.InnerHtml = "";
            ul_vendor_city.InnerHtml = "";
            ul_vendor_state.InnerHtml = "";
            ul_vendor_zip_code.InnerHtml = "";

            while (reader.Read())
            {
                ul_vendor_id.InnerHtml += "<li>" + reader["vendor_id"].ToString() + "</li>";
                ul_vname.InnerHtml += "<li>" + reader["vendor_name"].ToString() + "</li>";
                ul_v_address1.InnerHtml += "<li>" + reader["vendor_address1"].ToString() + "</li>";
                ul_v_address2.InnerHtml += "<li>" + reader["vendor_address2"].ToString() + "</li>";
                ul_vendor_city.InnerHtml += "<li>" + reader["vendor_city"].ToString() + "</li>";
                ul_vendor_state.InnerHtml += "<li>" + reader["vendor_state"].ToString() + "</li>";
                ul_vendor_zip_code.InnerHtml += "<li>" + reader["vendor_zip_code"].ToString() + "</li>";
            }

            conn.Close();
        } //end of btn_refresh2_Click

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        //===============================DELETE OF CRUD=========================================
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =

        protected void btn_delete_vendor_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = VendorTable.Models.CalvinDb.connectionString;

            int rows = 0;
            int vendor_id = Convert.ToInt32(drpdwn_v_id_delete.SelectedValue);

            string command = "DELETE FROM vendors WHERE vendor_id = :id";

            conn.Open();
 
            OracleCommand cmd = new OracleCommand(command, conn);
            cmd.Parameters.Add(new OracleParameter("id", vendor_id));


            rows = cmd.ExecuteNonQuery();

            lbl_oracle_message.Text += "<br/> " + Convert.ToString(rows) + " rows affected" + "<br/>";
            conn.Close();
        }


        protected void btn_refresh3_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = VendorTable.Models.CalvinDb.connectionString;

            conn.Open();
            OracleCommand cmd = new OracleCommand("SELECT * FROM vendors ORDER BY vendor_id", conn);
            OracleDataReader reader = cmd.ExecuteReader();

            ul_vendor_id.InnerHtml = "";
            ul_vname.InnerHtml = "";
            ul_v_address1.InnerHtml = "";
            ul_v_address2.InnerHtml = "";
            ul_vendor_city.InnerHtml = "";
            ul_vendor_state.InnerHtml = "";
            ul_vendor_zip_code.InnerHtml = "";

            while (reader.Read())
            {
                ul_vendor_id.InnerHtml += "<li>" + reader["vendor_id"].ToString() + "</li>";
                ul_vname.InnerHtml += "<li>" + reader["vendor_name"].ToString() + "</li>";
                ul_v_address1.InnerHtml += "<li>" + reader["vendor_address1"].ToString() + "</li>";
                ul_v_address2.InnerHtml += "<li>" + reader["vendor_address2"].ToString() + "</li>";
                ul_vendor_city.InnerHtml += "<li>" + reader["vendor_city"].ToString() + "</li>";
                ul_vendor_state.InnerHtml += "<li>" + reader["vendor_state"].ToString() + "</li>";
                ul_vendor_zip_code.InnerHtml += "<li>" + reader["vendor_zip_code"].ToString() + "</li>";
            }
            conn.Close();
        }
    } //end of Admin public partial class
} //end of namespace

