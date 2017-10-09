using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public int ID { get; set; }
        public short SignUpFee { get; set; }
        public byte Months { get; set; }
        public byte Discount { get; set; }
        public string Name { get; set; }
    }
}