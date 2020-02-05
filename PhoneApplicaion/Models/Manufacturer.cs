using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhoneApplicaion.Models
{
    public class Manufacturer
    {
        public Manufacturer() {
            ManufacturerName = "";
            Url = "";
            DateReleased = DateTime.Now;
            Founded = DateTime.Now;
        }
        [Key]
        public int ManufacturerId { get; set; }

        public String ManufacturerName { get; set; }
        public String Url { get; set; }
        public DateTime DateReleased { get; set; }
        public DateTime Founded{ get; set; }
        public List<Phone> PhoneList { get; set; }
        /*public List<Manufacturer> Manufacturers { get; set; }*/

    }
}