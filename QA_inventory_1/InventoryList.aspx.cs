using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using QA_inventory_1.Models;

namespace QA_inventory_1
{
    public partial class InventoryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Inventory> GetInventories([QueryString("id")] int?
categoryId)
        {
            var _db = new QA_inventory_1.Models.InventoryContext();
            IQueryable<Inventory> query = _db.Inventories;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}