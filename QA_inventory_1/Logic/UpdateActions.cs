using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QA_inventory_1.Models;
namespace QA_inventory_1.Logic
{
    public class UpdateActions : IDisposable
    {
       // public string ShoppingCartId { get; set; }
    private InventoryContext _db = new InventoryContext();
   // public const string CartSessionKey = "CartId";
    
         public void UpdateInventory(int id)
    {
        // Retrieve the product from the database.
       // ShoppingCartId = GetCartId();
        var cartItem = _db.Inventories.SingleOrDefault(
        c => c.InventoryID == id);
        if (cartItem == null)
        {
            
        }
        else
        {
            // If the item does exist in the cart,
            // then add one to the quantity.
            cartItem.Issued_by="ABC";
        }
        _db.SaveChanges();
    }
    public void Dispose()
    {
        if (_db != null)
        {
            _db.Dispose();
            _db = null;
        }
    }

}
}