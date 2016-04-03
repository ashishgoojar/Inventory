using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace QA_inventory_1.Models
{
    public class Inventory
    {
        [ScaffoldColumn(false)]
        public int InventoryID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string InventoryName { get; set; }
        [Required, StringLength(10000), Display(Name = "Inventory Description"),
       DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [StringLength(100),Display(Name = "Serial_Number")]
        public string Serial_Number { get; set; }
        [StringLength(100), Display(Name = "Currently_with")]
        public string Currently_with { get; set; }
        [StringLength(100), Display(Name = "Issued_by/Returned_by")]
        public string Issued_by { get; set; }
        [StringLength(100), Display(Name = "From Date")]
        public string from { get; set; }
        [StringLength(100), Display(Name = "To Date")]
        public string to { get; set; }

        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}