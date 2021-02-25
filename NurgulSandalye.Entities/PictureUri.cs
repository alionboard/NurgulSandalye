using System;
using System.Collections.Generic;
using System.Text;

namespace NurgulSandalye.Entities
{
    public class PictureUri : BaseEntity
    {
        public string Uri { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
