<%@ Page Title="Создание плана" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreatePlan.aspx.cs" Inherits="PlanViewer.createPlan" %>
<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
            </hgroup>
            <p>
                Пожалуйста, заполните все необходимые поля и нажмите кнопку "Отправить на согласование"
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Объект работ</h3>
    <asp:TextBox id="workObject" runat="server" />
    <br>
    <h3>Вид работ</h3>
    <asp:TextBox id="typeOfWork" runat="server" />
    <br>
    <h3>Наименование единичной расценки</h3>
    <asp:TextBox id="nameOfCost" runat="server" />
    <br>
    <h3>Единица измерения</h3>
    <asp:TextBox id="measure" runat="server" />
    <br>
    <h3>Трудозатраты (план)</h3>
    <asp:TextBox id="labour" runat="server" />
    <br>
    <h3>Материалы (план)</h3>
    <asp:TextBox id="materials" runat="server" />
    <br>
    <h3>Механизмы (план)</h3>
    <asp:TextBox id="mechanisms" runat="server" />
    <br>
    <h3>Заказчик</h3>
    <asp:TextBox id="customer" runat="server" />
    <br>
    <h3>Подрядчик</h3>
    <asp:TextBox id="contractor" runat="server" />
    <br>
    <asp:Button ID="ButtonSend" runat="server" onclick="ButtonSend_Click" Text="Отправить на согласование" />
</asp:Content>
