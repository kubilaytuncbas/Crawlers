using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        public String Brand { get; set; }
        public String ProductName { get; set; }
        public int ListPrice { get; set; }
        public int DealerPrice { get; set; }
    }
}
