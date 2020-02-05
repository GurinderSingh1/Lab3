using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhoneApplicaion.Models
{
    public class DataContext: DbContext
    {
  	public DbSet<Phone> Phone { get; set; }
	public DbSet<Manufacturer> Manufacturers { get; set; }
        public object Manufacturer { get; internal set; }
    }
}