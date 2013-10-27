<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Разработка приложения для сбора с подрядчиков информации о выполнении работ</h2>
    </hgroup>

    <article>
        <p>        
            Данное приложение создано командой TechUp в рамках курса по командному проекту
        </p>
    </article>

    <aside>
        <h3>Дополнительная информация</h3>

        <ul>
            <li><a runat="server" href="~/">Домой</a></li>
            <li><a runat="server" href="~/About">О программе</a></li>
            <li><a runat="server" href="~/Contact">Контакты</a></li>
        </ul>
    </aside>
</asp:Content>