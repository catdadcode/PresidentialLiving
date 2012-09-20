<%@ Page Title="Home" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresidentialLiving.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="admincontrols" runat="server" style="text-align: center;">
        <asp:Button ID="btnEdit" runat="server" Text="Edit This Page" 
            onclick="btnEdit_Click" />
    </div>
    <div id="contents" runat="server">
    </div>
</asp:Content>
