<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateInventory.aspx.cs" Inherits="QA_inventory_1.UpdateInventory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <meta charset="utf-8">
  
  <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
  <script src="//code.jquery.com/jquery-1.10.2.js"></script>
  <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
  <link rel="stylesheet" href="/resources/demos/style.css">
  <script>
  $(function() {
    $( "#datepicker1" ).datepicker();
  });
  $(function () {
      $("#datepicker2").datepicker();
  });
  </script>
      
    <asp:FormView ID="Updateinventory" runat="server"
ItemType="QA_inventory_1.Models.Inventory" SelectMethod ="GetInventory"
RenderOuterTable="false">
 <ItemTemplate>
 <div>
 <h1><%#:Item.InventoryName %></h1>
 </div>
    
 <br />
 <table>
 <tr>
 <td>
 <img src="/Catalog/Images/<%#:Item.ImagePath %>"
style="border:solid; height:300px" alt="<%#:Item.InventoryName %>"/>
 </td>
<td>&nbsp;</td>
<td style="vertical-align: top; text-align:left;">
 <b>Description:</b><br /><%#:Item.Description %><br /><span><b>Serial Number</b>&nbsp;<%#: String.Format("{0:c}",
Item.Serial_Number) %></span><br /><tr>
        <td>
            <span><b>Currently with:</b>&nbsp;
        </td>
        <td>
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                <asp:ListItem Selected="True" Text="Ashish Goojar"></asp:ListItem>
                <asp:ListItem Text="ABC"></asp:ListItem>
                <asp:ListItem Text ="QA Inventory"></asp:ListItem>
                <asp:ListItem Text="Others"></asp:ListItem>
            </asp:DropDownList></td>
    <td>

        <asp:TextBox ID="TextBox2" Text="" Visible="false" runat="server"></asp:TextBox>
    </td>
        </span>
    </tr>
        <tr>
        <td>
            <span><b>Last Issued by/Returned by:</b>&nbsp;
        </td>
        <td>
            <asp:DropDownList ID="DropDownList1"  AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Selected="True" Text ="Ashish Goojar"></asp:ListItem>
                <asp:ListItem Text="ABC"></asp:ListItem>
                <asp:ListItem Text="Others"></asp:ListItem>
            </asp:DropDownList></td>
                <td>

        <asp:TextBox ID="TextBox3" Text="" Visible="false" runat="server"></asp:TextBox>
    </td>
        </span>
    </tr>
     <br />
    <tr>
        <td>
           <span> 
  <p>From Date: </p></span> </td>
        <td>
           <span>
      <input type="text" id="datepicker1"> </span></td>
     <%-- <asp:DropDownList ID="DropDownList4" runat="server" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged">
          <asp:ListItem Selected="True" Text="Ashish Goojar"></asp:ListItem>
             <asp:ListItem Text="ABC"></asp:ListItem>
      </asp:DropDownList>--%>
            </tr>
     <br />

    <tr>
        <td>
           <span> 
  <p>To Date: </p></span> </td>
        <td>
           <span>
      <input type="text" id="datepicker2"> </span></td>

            </tr>
     <br />
     <br />
    <br />
    <tr>
      <td>

    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Submit</asp:LinkButton>
 </span>
 </td>
        <td>
    <span class="InventoryListItem">
     <a>
<href="/UpdateInventory.aspx?inventoryID=<%#:Item.InventoryID %>"><span class="InventoryListItem"><b>Cancel<b>
        </span>
           </a> </td>
        </tr>
 </td>
 </tr>
 </table>
 </ItemTemplate>
 </asp:FormView>
</asp:Content>
