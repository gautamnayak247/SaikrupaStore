using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreObjects
{
    public class SaleProduct
    {
        //[Required]
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public string ItemCode { get; set; }
        public int CategoryId { get; set; }
        public string CategoryDescription { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
