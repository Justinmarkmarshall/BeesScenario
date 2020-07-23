<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bees._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Bees</h1>
        <p class="lead">A technical test for HESA</p>
    </div>

    <table class="table">
        <thead>
            <tr>
                <th>Health</th>
                <th>Is Dead</th>
                <th>Attack Button</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="rpt_Bees" runat="server" OnItemCommand="rpt_BeesItemCommand">
                <ItemTemplate>
                    <tr>
                        <td><%# DataBinder.Eval(Container.DataItem, "db_Health") %> </td>
                        <td><%# DataBinder.Eval(Container.DataItem, "bDead") %> </td>
                        <td>
                            <asp:Button ID="btn_InflictDamage" Text="Damage" CssClass="btn btn-primary" runat="server" CommandName="Damage" /></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </tbody>
    </table>


</asp:Content>
