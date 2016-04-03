<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InventoryDetails.aspx.cs" Inherits="QA_inventory_1.InventoryDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <asp:FormView ID="inventoryDetail" runat="server"
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
 <b>Description:</b><br /><%#:Item.Description %>
<br />
 <span><b>Serial Number</b>&nbsp;<%#: String.Format("{0:c}",
Item.Serial_Number) %></span>
 <br />
<span><b>Currently with:</b>&nbsp;<%#:Item.Currently_with
%></span>
     <br />
    <span><b>Last Issued by/Returned by:</b>&nbsp;<%#:Item.Issued_by
%></span>
     <br />
    <span><b>From date:</b>&nbsp;<%#:Item.from
%></span>
     <br />
    <span><b>To date:</b>&nbsp;<%#:Item.to
%></span>
 <br />
    <a
href="/UpdateInventory.aspx?inventoryID=<%#:Item.InventoryID %>">
 <span class="InventoryListItem">
 <b>Issue/Return<b>
 </span>
 </a>
 </td>
 </tr>
 </table>
 </ItemTemplate>
 </asp:FormView>
</asp:Content>
