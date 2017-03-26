using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreObjects
{
    public class ItemDetails
    {
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public string ItemCode { get; set; }
        [DisplayName("Category Id")]
        public int CategoryId { get; set; }
        public string CategoryDescription { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public bool IsDirty { get; set; }
    }
}
