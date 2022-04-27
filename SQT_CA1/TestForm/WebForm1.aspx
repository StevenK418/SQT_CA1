<%@ Page Title="WebForm1" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestForm.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <br/>
    <br/>
    <div class="container">
        <form>
            <legend>Insurance Tester</legend>
            <label> Age: </label>
            <asp:TextBox ID="age" class="form-control" runat="server"></asp:TextBox>
            <label>Location: </label>
            <asp:TextBox ID="location" class="form-control"  runat="server"></asp:TextBox> 
            <br />
            <asp:Label runat="server" ID="resultField" runat="server"></asp:Label>
            <br />
            <br/>
            <asp:Button runat="server" class="form-control" type="button" text="Calculate Premium" ID="btnSubscribe" OnClick="btnSubscribe_Click"/>
            <br/>
        </form>
       
    </div>
   
</asp:Content>
