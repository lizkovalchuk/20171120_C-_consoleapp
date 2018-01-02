using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRental.Models;

namespace CarRental
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Renter person1 = new Renter();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void button_click(object sender, EventArgs e)
        {
            //Validate the first and last name
            
           bool isOk = true;

            if (f_name_txtbox.Text == "")
            {
                lbl_f_name.Text = "Please enter your first name";
                isOk = false;                
            }

            else
            {
                string f_name_userinput = f_name_txtbox.Text;
                person1.First_Name = f_name_userinput;
            }

           if(l_name_txtbox.Text == "")
            {
                lbl_l_name.Text = "Please enter your last name";
                isOk = false;
            }

           else
            {
                string l_name_userinput = l_name_txtbox.Text;
                person1.Last_Name = l_name_userinput;
                
            }

           //Add the gender to the class object

           if(lbl_gender1.Checked) {
                person1.Gender = lbl_gender1.Text;
            }
            
           else if(lbl_gender2.Checked)
            {
                person1.Gender = lbl_gender2.Text;
                lbl_gender_result.Text = person1.Gender;
            }
            else
            {
                lbl_gender.Text = "Please provide your gender";
            }

            //Add the Date of Birth

            if (String.IsNullOrWhiteSpace(input_dob.Value)) {
                lbl_dob.Text = "Please provide your date of birth";
                isOk = false;
            }
            else
            {                
                person1.DOB = DateTime.Parse(input_dob.Value);                
            }

            //License Plate Number

            if (l_num_txtbox.Text == "" || l_num_txtbox.Text.Length != 10 )
            {
                lbl_l_num.Text = "Please enter a valid license number";
                isOk = false;
            }           
            else
            {
                string lnum_userinput = l_num_txtbox.Text;
                person1.L_num = lnum_userinput;                
            }

            //Province Input

            if (prov_txtbox.Text == "")
            {
                lbl_prov.Text = "Please enter a valid province";
                isOk = false;
            }
            else if(prov_txtbox.Text.ToLower() == "ontario")
            {
                string prov_userinput = prov_txtbox.Text;
                person1.Prov = prov_userinput;
                
            }
            else if(prov_txtbox.Text.ToLower() == "quebec")
            {
                string prov_userinput = prov_txtbox.Text;
                person1.Prov = prov_userinput;
            }
            else if (prov_txtbox.Text.ToLower() == "british columbia")
            {
                string prov_userinput = prov_txtbox.Text;
                person1.Prov = prov_userinput;
            }
            else if (prov_txtbox.Text.ToLower() == "alberta")
            {
                string prov_userinput = prov_txtbox.Text;
                person1.Prov = prov_userinput;
            }
            else if(prov_txtbox.Text.ToLower() == "nova scotia")
            {
                string prov_userinput = prov_txtbox.Text;
                person1.Prov = prov_userinput;
            }
            else if (prov_txtbox.Text.ToLower() == "saskatchewan")
            {
                string prov_userinput = prov_txtbox.Text;
                person1.Prov = prov_userinput;
            }
            else if (prov_txtbox.Text.ToLower() == "manitoba")
            {
                string prov_userinput = prov_txtbox.Text;
                person1.Prov = prov_userinput;
            }
            else if (prov_txtbox.Text.ToLower() == "newfoundland and labrador")
            {
                string prov_userinput = prov_txtbox.Text;
                person1.Prov = prov_userinput;
            }
            else if (prov_txtbox.Text.ToLower() == "new brunswick")
            {
                string prov_userinput = prov_txtbox.Text;
                person1.Prov = prov_userinput;
            }
            else if (prov_txtbox.Text.ToLower() == "prince edward island")
            {
                string prov_userinput = prov_txtbox.Text;
                person1.Prov = prov_userinput;
            }

            //Withhold display unless all feilds are correctly inputed

            if (isOk == false)
            {
                return;
            }
            else
            {
                lbl_fullname_result.Text = person1.First_Name + " " + person1.Last_Name;
                lbl_gender_result.Text = person1.Gender;
                lbl_age_result.Text = person1.Age.ToString();
                lbl_lnum_result.Text = person1.L_num;
                lbl_province_result.Text = person1.Prov;
            }
        } // end of button click
    } // end of public partial class
} // end of namespace