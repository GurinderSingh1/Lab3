using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneApplicaion.Models
{
    public class Phone
    {
      


        public Phone() {
            phoneId = 0 ;
            phoneName = "";
            manufacturer = "";
            msrp = 0;
            Screensize = 0;
            DateReleased = DateTime.Now;

        }
        public string phoneName { get; set; }
        public int phoneId { get; set; }
        public  double  msrp { get; set; }
        public double Screensize { get; set; }
        public DateTime DateReleased { get; set; }
        public string manufacturer { get; set; }
 
   
    }
}