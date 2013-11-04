<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPlan.aspx.cs" Inherits="PlanViewer.ViewPlan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="PlansDataSource" DataTextField="res" DataValueField="res" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:SqlDataSource ID="PlansDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:TeamProjectDBConnectionString1 %>" OnSelecting="PlansDataSource_Selecting" SelectCommand="SELECT 'Plan #' + CAST([ID] AS varchar(5)) +' On object'+ [Object] as res FROM [Plan]"></asp:SqlDataSource>
    <asp:Table ID="Table1" runat="server" >
        <asp:TableHeaderRow BorderStyle="Dashed">
            <asp:TableHeaderCell BorderStyle="Double">ID </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Заказчик </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Подрядчик </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Объект работ </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Вид работ </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Наимменование единичной расценки </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Единица измерения </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Трудозатраты </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Материалы </asp:TableHeaderCell>
            <asp:TableHeaderCell BorderStyle="Double">Механизмы </asp:TableHeaderCell>            
            <asp:TableHeaderCell BorderStyle="Double">Текущий статус </asp:TableHeaderCell>       
        </asp:TableHeaderRow>
        <asp:TableRow BorderStyle="Dashed">
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
            <asp:TableCell Width="76"></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Одобрить" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Отклонить"/>
    
</asp:Content>
