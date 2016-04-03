using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace QA_inventory_1.Models
{
    public class InventoryDatabaseInitializer : DropCreateDatabaseAlways<InventoryContext>
    {
        protected override void Seed(InventoryContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetInventories().ForEach(p => context.Inventories.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
 new Category
 {
 CategoryID = 1,
CategoryName = "Traffic Testers"
 },
 new Category
 {
 CategoryID = 2,
CategoryName = "Optical Power Meters"
 },
  new Category
 {
 CategoryID = 3,
CategoryName = "Variable Optical Attenuators"
 },
   new Category
 {
 CategoryID = 4,
CategoryName = "Couplers"
 },
    new Category
 {
 CategoryID = 5,
CategoryName = "Attenuators"
 },
   new Category
 {
 CategoryID = 6,
CategoryName = "Optical Patch Cords"
 },
   new Category
 {
 CategoryID = 7,
CategoryName = "Misc"
 },
   };
            return categories;

        }
        private static List<Inventory> GetInventories()
        {
            var inventories = new List<Inventory> {
 new Inventory
 {
 InventoryID = 1,
InventoryName = "VIAVI MTS 5800",
Description = "This is a Traffic tester with SDH/ OTN/ Ethernet traffic generation capability",
 ImagePath="jdsu_5800_1.png",
 Serial_Number="ABC12345678",
Currently_with="QA inventory",
Issued_by="Ashish Goojar",
from="01-Apr-2016",
to="11-Apr-2016",
CategoryID = 1
 }
            };
            return inventories;
        }
    }
}