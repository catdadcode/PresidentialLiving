<%@ Page Title="Change Password" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="PresidentialLiving.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 align="center">
        Change Password</h1>
    Old Password:
    <asp:TextBox ID="tbxOldPassword" TextMode="Password" Width="250px" runat="server"></asp:TextBox>
    <br />
    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="* Old Password Is Incorrect"></asp:CustomValidator>
    <br />
    New Password:
    <asp:TextBox ID="tbxPassword" TextMode="Password" Width="250px" runat="server"></asp:TextBox>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="tbxPassword"
        runat="server" ErrorMessage="* Required"></asp:RequiredFieldValidator>
    <br />
    Confirm Password:
    <asp:TextBox ID="tbxConfirmPassword" TextMode="Password" Width="250px" runat="server"></asp:TextBox>
    <br />
    <asp:CompareValidator ID="CompareValidator1" ControlToCompare="tbxConfirmPassword"
        ControlToValidate="tbxPassword" runat="server" ErrorMessage="* Passwords Do Not Match"></asp:CompareValidator>
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
        onclick="btnSubmit_Click" />
</asp:Content>
