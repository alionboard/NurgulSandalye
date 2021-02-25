using System;
using System.Collections.Generic;
using System.Text;

namespace NurgulSandalye.Entities
{
    public class Adress : BaseEntity
    {
        public string LongAdress { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
    }
}
