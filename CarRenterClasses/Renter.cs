using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental.Models
{
    public class Renter : Person
    {
        //Fields
        private string _lnum;
        private string _prov;

        //Properties
        public string L_num
        {
            get { return this._lnum; }
            set { this._lnum = value; }
        }

        public string Prov
        {
            get { return this._prov; }
            set { this._prov = value; }
        }
    }
}