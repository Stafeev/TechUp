<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewPlan.aspx.cs" Inherits="PlanViewer.NewPlan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ID">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TeamProjectDBConnectionString1 %>" SelectCommand="SELECT [ID], [Name] FROM [Customer]"></asp:SqlDataSource>
    <div>
        <asp:Panel runat="server" ID="Panel3">
            <asp:GridView GridLines="Both" Width="" Caption="План" ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="ID" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:TemplateField HeaderText="№  " HeaderStyle-HorizontalAlign="Center">
                <EditItemTemplate>
                    <asp:Label ID="ID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="ID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:Label ID="ID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Объект работ">
                <EditItemTemplate>
                    <asp:TextBox ID="FactObject" runat="server" Text='<%# Bind("FactObject") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="FactObjectlab" runat="server" Text='<%# Bind("FactObject") %>' ></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="FactObject" runat="server" Text='<%# Bind("FactObject") %>' ></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Вид работ">
                <EditItemTemplate>
                    <asp:TextBox ID="WorkType" runat="server" Text='<%# Bind("WorkType") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="WorkTypelab" runat="server" Text='<%# Bind("WorkType") %>' ></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="WorkType" runat="server" Text='<%# Bind("WorkType") %>' ></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Наименование единичной расценки">
                <EditItemTemplate>
                    <asp:TextBox ID="CostName" runat="server" Text='<%# Bind("CostName") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="CostNamelab" runat="server" Text='<%# Bind("CostName") %>' ></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="CostName" runat="server" Text='<%# Bind("CostName") %>' ></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Единицы измерения">
                <EditItemTemplate>
                    <asp:TextBox ID="UnitName" runat="server" Text='<%# Bind("UnitName") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="UnitNamelab" runat="server" Text='<%# Bind("UnitName") %>' ></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="UnitName" runat="server" Text='<%# Bind("UnitName") %>' ></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Трудозатраты">
                <EditItemTemplate>
                    <asp:TextBox ID="Labor" runat="server" Text='<%# Bind("Labor") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Laborlab" runat="server" Text='<%# Bind("Labor") %>' ></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="Labor" runat="server" Text='<%# Bind("Labor") %>' ></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Материалы">
                <EditItemTemplate>
                    <asp:TextBox ID="Materials" runat="server" Text='<%# Bind("Materials") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Materialslab" runat="server" Text='<%# Bind("Materials") %>' ></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="Materials" runat="server" Text='<%# Bind("Materials") %>' ></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Механизмы">
                <EditItemTemplate>
                    <asp:TextBox ID="Mechanisms" runat="server" Text='<%# Bind("Mechanisms") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Mechanismslab" runat="server" Text='<%# Bind("Mechanisms") %>' ></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="Mechanisms" runat="server" Text='<%# Bind("Mechanisms") %>' ></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>        
            <asp:CommandField ShowEditButton="true" />
            <asp:CommandField ShowDeleteButton="true" />                          
            
        </Columns>
                <EditRowStyle CssClass="GridViewEditRow" />
                
        </asp:GridView>
        </asp:Panel>
    </div>
</asp:Content>
