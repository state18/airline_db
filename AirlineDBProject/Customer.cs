using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineDBProject {
    public class Customer {
        public string customer_id { get; set; }
        public string username { get; set; }
        public string passwd{ get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string phone { get; set; }
        public string dob { get; set; }
        public string email { get; set; }
        public string date_created { get; set; }
        public string stAddress { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }

        public string FullInfo {
            get {
                return $"{fName} {lName} ({phone})";
            }
        }


    }
}
