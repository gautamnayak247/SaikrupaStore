using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreObjects
{
    public class NewItemDetails
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public double SalePrice { get; set; }
        public double PurchasePrice { get; set; }
        public bool IsActive { get; set; }
        public string ItemCode { get; set; }
    }
}
