﻿<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="PlanViewer.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1>Команда TechUP <%: Title %></h1>
    </hgroup>

    <article>
        <p>        
            Национальный Исследовательский Университет - Высшая Школа Экономики</p>

        <p>        
            Стафеев Артём</p>
        <p>        
            Сотов Александр
        </p>
        <p>        
            Захаров Егор</p>
        <p>        
            Лапидус Егор</p>
        <p>        
            &nbsp;</p>
    </article>

    <aside>
        <h3>Aside Title</h3>
        <p>        
            Use this area to provide additional information.
        </p>
        <ul>
            <li><a runat="server" href="~/">Home</a></li>
            <li><a runat="server" href="~/About">About</a></li>
            <li><a runat="server" href="~/Contact">Contact</a></li>
        </ul>
    </aside>
</asp:Content>