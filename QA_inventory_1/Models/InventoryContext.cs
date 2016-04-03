using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace QA_inventory_1.Models
{
    public class InventoryContext : DbContext
    {
        public InventoryContext() : base("QA_inventory_1")
 {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
    }
}