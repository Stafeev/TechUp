<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPlan.aspx.cs" Inherits="PlanViewer.ViewPlan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">


    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="PlanID" OnDataBound="DropDownList1_DataBound" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TeamProjectDBConnectionString1 %>" SelectCommand="SELECT DISTINCT Contractor.Name, [Plan].PlanID FROM [Plan] INNER JOIN Contractor ON [Plan].Contractor = Contractor.ID"></asp:SqlDataSource>
    <asp:Panel runat="server" ID="Panel3">
            <asp:GridView BackColor="LightBlue" GridLines="Both" BorderWidth="1px" Width="" Caption="Факт" ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="ID" >
        <Columns>
            <asp:TemplateField HeaderText="№  " HeaderStyle-HorizontalAlign="Center">
                <EditItemTemplate>
                    <asp:Label ID="ID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="ID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Объект работ">
                <EditItemTemplate>
                    <asp:TextBox ID="FactObject" runat="server" Text='<%# Bind("Object") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="FactObjectlab" runat="server" Text='<%# Bind("Object") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Вид работ">
                <EditItemTemplate>
                    <asp:TextBox ID="WorkType" runat="server" Text='<%# Bind("WorkType") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="WorkTypelab" runat="server" Text='<%# Bind("WorkType") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Наименование единичной расценки">
                <EditItemTemplate>
                    <asp:TextBox ID="CostName" runat="server" Text='<%# Bind("CostName") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="CostNamelab" runat="server" Text='<%# Bind("CostName") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Единицы измерения">
                <EditItemTemplate>
                    <asp:TextBox ID="UnitName" runat="server" Text='<%# Bind("UnitName") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="UnitNamelab" runat="server" Text='<%# Bind("UnitName") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Трудозатраты">
                <EditItemTemplate>
                    <asp:TextBox ID="Labor" runat="server" Text='<%# Bind("Labor") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Laborlab" runat="server" Text='<%# Bind("Labor") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Материалы">
                <EditItemTemplate>
                    <asp:TextBox ID="Materials" runat="server" Text='<%# Bind("Materials") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Materialslab" runat="server" Text='<%# Bind("Materials") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Механизмы">
                <EditItemTemplate>
                    <asp:TextBox ID="Mechanisms" runat="server" Text='<%# Bind("Mechanisms") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Mechanismslab" runat="server" Text='<%# Bind("Mechanisms") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>                                       
        </Columns>
                <EditRowStyle CssClass="GridViewEditRow" />
                
        </asp:GridView>
        </asp:Panel>
    
   
    
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Одобрить" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Отклонить"/>
    
</asp:Content>
