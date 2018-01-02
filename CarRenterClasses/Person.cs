using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


    public class Person
    {
        //Fields
        private string _first_name;
        private string _last_name;
        private string _gender;  
        private DateTime _dob;
        private string _l_num;
        private string _prov;

        //Properties

        public string First_Name
        {
            get { return this._first_name; }
            set { this._first_name = value; }
        }

        public string Last_Name
        {
            get { return this._last_name; }
            set { this._last_name = value; }
        }

        public string Full_Name
        {
            get { return this._first_name + " " + this._last_name; }
        }

        public string Gender
        {
            get { return this._gender; }
            set { this._gender = value; }
        }

    //Calculate Age with the Date of Birth

        public DateTime DOB
        {
              get { return this._dob; }
              set { this._dob = value; }
        }

        public int Age 
        {
            get {
            DateTime _today = DateTime.Now;
            TimeSpan _result = _today - _dob;
            int _days = _result.Days;
            double result = _days / 365;
            int _age = (int)Math.Floor(result);
            return _age;
            }
        }

        public string L_num
        {
            get { return this._l_num; }
            set { this._l_num = value; }
        }

        public string Prov
        {
            get { return this._prov; }
            set { this._prov = value; }
        }
          

    
    } //end of public class

// } // end of namespace