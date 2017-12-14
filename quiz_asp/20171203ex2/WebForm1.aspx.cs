using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20171203ex2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void button_click(object sender, EventArgs e)
        {
            //starting score starts at zero

            int score = 0;

            //Question 1

            if(capital_textbox.Text == "Riga")
            {
                score++;
            }

            else
            {
                capital_label.Text = "Riga";
            }

            //Question 2

            if(province_textbox.Text == "10")
            {
                score++;
            }

            else
            {
                province_label.Text = "10";
            }
            
            //Question 3

            if(subway_textbox.Text == "4")
            {
                score++;
            }

            else
            {
                subway_label.Text = "4";
            }

            //Question 4

            if(tree1.Checked == true)
            {
                score++;
            }

            else
            {

            }

            //Question 5

            if(lift1.Checked == true)
            {
                score++;
            }

            //Final Text

            if(score == 0)
            {
                Submit.Text = "Your score is " + score + ". Please try again";
            }

            else if(score <= 3 && score > 1)
            {
                Submit.Text = "Your score is " + score + ". Not bad";
            }

            else
            {
                Submit.Text = "Your score is " + score + ". Awesome"; 
            }
            //Last Three Curly Braces

        }
        
    }
}