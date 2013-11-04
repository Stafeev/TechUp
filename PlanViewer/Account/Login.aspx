<%@ Page Title="Вход в систему" Language="C#" EnableEventValidation="false" MasterPageFile="~/LoginRegister.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PlanViewer.Login" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>   
<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Выберите вариант входа в систему</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>

 <asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
        <link rel="stylesheet" type="text/css" href="style.css" />
             <link rel="stylesheet" type="text/css" href="css/buttons.css">
        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.1/jquery.min.js"></script>
		<script type="text/javascript">
            (function($){$.fn.extend({leanModal:function(options){var defaults={top:100,overlay:0.5,closeButton:null};var overlay=$("<div id='lean_overlay'></div>");$("body").append(overlay);options=$.extend(defaults,options);return this.each(function(){var o=options;$(this).click(function(e){var modal_id=$(this).attr("href");$("#lean_overlay").click(function(){close_modal(modal_id)});$(o.closeButton).click(function(){close_modal(modal_id)});var modal_height=$(modal_id).outerHeight();var modal_width=$(modal_id).outerWidth();
            $("#lean_overlay").css({"display":"block",opacity:0});$("#lean_overlay").fadeTo(200,o.overlay);$(modal_id).css({"display":"block","position":"fixed","opacity":0,"z-index":11000,"left":50+"%","margin-left":-(modal_width/2)+"px","top":o.top+"px"});$(modal_id).fadeTo(200,1);e.preventDefault()})});function close_modal(modal_id){$("#lean_overlay").fadeOut(200);$(modal_id).css({"display":"none"})}}})})(jQuery);
		</script>
		<script type="text/javascript">
		    $(function () {
		        $('a[rel*=leanModal]').leanModal({ top: 200, overlay: 0.4, closeButton: ".modal_close" });
		    });
		</script>
        <div style="float:left">
        <asp:Login ID="Customer" runat="server" 
            RememberMeSet="false"
            DisplayRememberMe="false"
           LoginButtonText="Войти как заказчик"
            UserNameLabelText="email"
            FailureText="Неверный логин или пароль"
            TitleText="Вход для заказчика"
           DestinationPageUrl="~/Default.aspx">
        </asp:Login>
            </div>
        <div style="float:right">
            <asp:Login ID="Contractor" runat="server"
            RememberMeSet="false" 
            DisplayRememberMe="false"
           LoginButtonText="Войти как подрядчик"
            UserNameLabelText="email"
            FailureText="Неверный логин или пароль"
            TitleText="Вход для подрядчика"
           DestinationPageUrl="~/Default.aspx">
        </asp:Login>
            </div>
     <br>
     <div style="margin-left: auto; margin-right: auto; text-align: center;">
    <a class="green goodbutton" a id="customerRegister" rel="leanModal" name="signup" href="#signupCustomer">Зарегистрировать заказчика</a>
    <br>
    <a class="green goodbutton" a id="contractorRegister" rel="leanModal" name="signup" href="#signupContractor">Зарегистрировать подрядчика</a>
            <div id="signupCustomer" class="signup" style="display: none; position:fixed; opacity: 1; z-index: 11000; left: 50%; margin-left: -202px; top: 200px;">
			<div class="signup-ct">
				<div class="signup-header">
					<h2>Регистрация заказчика</h2>
				</div>
				
				<form action="">
     
				  <div class="txt-fld">
				    <label for="">ФИО</label>
				    <input id="CustomerName"  name="" type="text" />

				  </div>
				  <div class="txt-fld">
				    <label for="">email</label>
				    <input id="CustomerEmail" name="" type="text" />
				  </div>
				  <div class="txt-fld">
				    <label for="">Пароль</label>
				    <input id="CustomerPassword" name="" type="password" />
                      </div>

                  <div class="txt-fld">
				    <label for="">Пароль еще раз</label>
				    <input id="CustomerPassword2" name="" type="password" />
                    </div>

				  <div class="btn-fld">
				  <button id="buttonCustomer"type="submit">Зарегистрироваться &raquo;</button>
				  </div>
				 </form>
			</div>
		</div>

         <div id="signupContractor" class="signup" style="display: none; position: fixed; opacity: 1; z-index: 11000; left: 50%; margin-left: -202px; top: 200px;">
			<div class="signup-ct">
				<div class="signup-header">
					<h2>Регистрация подрядчика</h2>
				</div>
				
				<form action="">
     
				  <div class="txt-fld">
				    <label for="">ФИО</label>
				    <input id="ContracorName"  name="" type="text" />

				  </div>
				  <div class="txt-fld">
				    <label for="">email</label>
				    <input id="ContracorEmail" name="" type="text" />
				  </div>
				  <div class="txt-fld">
				    <label for="">Пароль</label>
				    <input id="ContracorPassword" name="" type="password" />
                      </div>

                  <div class="txt-fld">
				    <label for="">Пароль еще раз</label>
				    <input id="ContracorPassword2" name="" type="password" />
				  </div>

				  <div class="btn-fld">
				  <button id="buttonContracor"type="submit">Зарегистрироваться &raquo;</button>
				  </div>
				 </form>
			</div>
		</div>

        </div>
    </asp:Content>