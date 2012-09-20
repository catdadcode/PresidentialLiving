<%@ Page Title="Edit Content" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditPage.aspx.cs" Inherits="PresidentialLiving.EditPage" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <CKEditor:CKEditorControl ID="rteBody" Width="875px" BasePath="/ckeditor/" runat="server"></CKEditor:CKEditorControl>
    <br />
    <center>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit Changes" 
            onclick="btnSubmit_Click" />
    </center>
</asp:Content>
