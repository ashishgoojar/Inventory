<%@ Control Language="C#" CodeBehind="ForeignKey.ascx.cs" Inherits="QA_inventory_1.ForeignKeyField" %>

<asp:HyperLink ID="HyperLink1" runat="server"
    Text="<%# GetDisplayString() %>"
    NavigateUrl="<%# GetNavigateUrl() %>"  />

