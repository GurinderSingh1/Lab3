using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PhoneApplicaion.Models
{
    public class Phone
    {



        public Phone() {

            PhoneId = 0;
            PhoneName = "";
            DateReleased = DateTime.Now;
           

        }
        public string PhoneName { get; set; }
        [Key]
        public int PhoneId { get; set; }

        [ForeignKey("Manufacturer")]
        public int ManufacturerId { get; set; }
        public double msrp { get; set; }
        public double Screensize { get; set; }
        public DateTime DateReleased { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
    }
}