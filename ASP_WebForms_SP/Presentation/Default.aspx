<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Presentation._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>LOGIN</h1>
        <asp:Label ID="Label1" runat="server" Text="User: "></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
        <br />
        <br />
        <%
            ////bool value = Request.QueryString();
            //if (value) { 
        %>
        <h1>CRUD Rol</h1>
        <asp:Label ID="Label3" runat="server" Text="ID: "></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Name: "></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnadd" runat="server" Text="Add" OnClick="btnadd_Click" />
        &nbsp;
        <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" />
        &nbsp;
        <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID_R" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ID_R" HeaderText="ID_R" InsertVisible="False" ReadOnly="True" SortExpression="ID_R" />
                <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB_WEBFORMConnectionString %>" SelectCommand="SELECT * FROM [ROLES]"></asp:SqlDataSource>
        <%
            //}
        %>
    </div>
</asp:Content>
