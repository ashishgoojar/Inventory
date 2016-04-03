<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InventoryList.aspx.cs" Inherits="QA_inventory_1.InventoryList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <section>
 <div>
 <hgroup>
 <h2><%: Page.Title %></h2>
 </hgroup>
 <asp:ListView ID="inventoryList" runat="server"
 DataKeyNames="InventoryID" GroupItemCount="4"
 ItemType="QA_inventory_1.Models.Inventory" SelectMethod="GetInventories">
 <EmptyDataTemplate>
 <table >
 <tr>
 <td>No data was returned.</td>
 </tr>
 </table>
 </EmptyDataTemplate>
 <EmptyItemTemplate>
 <td/>
 </EmptyItemTemplate>
 <GroupTemplate>
 <tr id="itemPlaceholderContainer" runat="server">
 <td id="itemPlaceholder" runat="server"></td>
 </tr>
 </GroupTemplate>
 <ItemTemplate>
 <td runat="server">
 <table>
 <tr>
 <td>
 <a
href="InventoryDetails.aspx?inventoryID=<%#:Item.InventoryID%>">
     <img
src="/Catalog/Images/Thumbs/<%#:Item.ImagePath%>"
 width="100" height="75" style="border:
solid" /></a>
 </td>
 </tr>
<tr>
 <td>
 <a
href="InventoryDetails.aspx?inventoryID=<%#:Item.InventoryID%>">
 <span>
 <%#:Item.InventoryName%>
 </span>
 </a>
<br />
<span>
 <b>Serial Number: </b><%#:String.Format("{0:c}",
Item.Serial_Number)%>
 </span>
<br />
 </td>
 </tr>
 <tr>
 <td>&nbsp;</td>
 </tr>
 </table>
</p>
 </td>
 </ItemTemplate>
 <LayoutTemplate>
 <table style="width:100%;">
 <tbody>
 <tr>
 <td>
 <table id="groupPlaceholderContainer"
runat="server" style="width:100%">
 <tr id="groupPlaceholder"></tr>
 </table>
 </td>
 </tr>
<tr>
 <td></td>
 </tr>
<tr></tr>
 </tbody>
 </table>
 </LayoutTemplate>
 </asp:ListView>
 </div>
 </section>
</asp:Content>
