using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QA_inventory_1.Models;
using System.Web.ModelBinding;
namespace QA_inventory_1
{
    public partial class InventoryDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Inventory> GetInventory([QueryString("inventoryID")] int?
inventoryId)
        {
            var _db = new QA_inventory_1.Models.InventoryContext();
            IQueryable<Inventory> query = _db.Inventories;
            if (inventoryId.HasValue && inventoryId > 0)
            {
                query = query.Where(p => p.InventoryID == inventoryId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}