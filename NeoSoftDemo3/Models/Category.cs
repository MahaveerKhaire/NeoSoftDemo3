using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoSoftDemo3.Models
{
    public class Category 
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Image { get; set; }
        public string StortDescription { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBY { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? UpdateBY { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedBY { get; set; }
        public bool IsActive{ get; set; }

    }
}
