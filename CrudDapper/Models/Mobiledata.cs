using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudDapper.Models
{
    public class Mobiledata
    {
        public int MobileID { get; set; }
        public string MobileName { get; set; }
        public string MobileIMEno { get; set; }
        public string MobileManufactured { get; set; }
        public decimal Mobileprice { get; set; }
    }
}