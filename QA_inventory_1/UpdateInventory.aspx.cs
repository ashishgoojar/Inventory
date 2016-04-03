using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QA_inventory_1.Models;
using System.Diagnostics;
using QA_inventory_1.Logic;
using System.Web.ModelBinding;
using System.Web.UI.WebControls.WebParts;
using System.IO;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.ComponentModel;
using System.Text;

//using System.Globalization;
namespace QA_inventory_1
{
    public partial class UpdateInventory : System.Web.UI.Page
    {
       

        // protected global::System.Web.UI.WebControls.TextBox TextBox1;
        // TextBox1.Text="";
        Panel pnlCalendar = new Panel();
        UpdatePanel up1 = new UpdatePanel();
        TextBox TextBox1 = new TextBox();        TextBox TextBox2 = new TextBox();        TextBox TextBox3 = new TextBox();        DropDownList DropDownList3 = new DropDownList();
        DropDownList DropDownList1 = new DropDownList();
        Calendar Calendar1 = new Calendar();
        Label Label1= new Label();
        Label Label2 = new Label();
       // int id1 = new int();
        int? id2 = new int();
        string Current = "";
        string Issued = "";
        //string temp1 = new string();
        private InventoryContext _db1 = new QA_inventory_1.Models.InventoryContext();
        //protected global::System.Web.UI.WebControls.Calendar Calendar1;
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //   temp1 = Label1.Text;
            // id1 = ToInt32(temp1);
           // if (Int32.TryParse(Label1.Text, out id1))
           // { id2 = id1;
           // }
                
            var updateItem = _db1.Inventories.SingleOrDefault(c => c.InventoryID == id2);
            if (updateItem == null)
            {

            }
            else
            {
                if (TextBox2.Text == "")
                { Current = DropDownList3.SelectedItem.Text; }
                else
                { Current = TextBox2.Text; };
                if (TextBox3.Text == "")
                { Issued = DropDownList1.SelectedItem.Text; }
                else
                { Issued = TextBox3.Text; };

                updateItem.Currently_with = Current;
                updateItem.Issued_by = Issued;
            }
            _db1.SaveChanges();
            Response.Redirect("Default.aspx");
         }

       

        protected void Page_Load(object sender, EventArgs e)
        {
            // TextBox1.Text = "";
            string rawId = Request.QueryString["InventoryID"];
            int productId;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out productId))
            {

                id2 = productId;
                   
                
            }
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
            Label1.Text = Calendar1.SelectedDate.ToLongDateString();
            TextBox1.AutoPostBack = true;

        }
        public IQueryable<Inventory> GetInventory([QueryString("inventoryID")] int?
inventoryId)
        {
            var _db = new QA_inventory_1.Models.InventoryContext();
            IQueryable<Inventory> query = _db.Inventories;
            if (inventoryId.HasValue && inventoryId > 0)
            {
                query = query.Where(p => p.InventoryID == inventoryId);
                var cartItem = _db.Inventories.SingleOrDefault(c => c.InventoryID == inventoryId);
                if (cartItem == null)
                {

                }
                else
                {
                    //  id1 = cartItem.InventoryID;
                    // If the item does exist in the cart,
                    // then add one to the quantity.
                     // cartItem.Issued_by = datepicker1.value;
                    id2 = inventoryId;
                     //Label1.Text = id1.ToString();
                }
                _db.SaveChanges();
            }
            else
            {
                query = null;
            }
            return query;
        }

        //protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Current = DropDownList4.SelectedItem.Text;
        //}

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList3.SelectedItem != null && DropDownList3.SelectedItem.Text == "Others")
            {
                //  Label1.Visible = true;
                TextBox2.Visible = true;
            }
            else
                Current = DropDownList3.SelectedItem.Text.ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem != null && DropDownList1.SelectedItem.Text == "Others")
            {
                //  Label1.Visible = true;
                TextBox3.Visible = true;
            }
            else
                Issued = DropDownList1.SelectedItem.Text.ToString();
        }

    }
}
