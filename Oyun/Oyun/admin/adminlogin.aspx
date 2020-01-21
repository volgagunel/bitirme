<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="Oyun.admin.adminlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
     <link href="/style.css" rel="stylesheet" />
</head>
<body>


    <div style="width:285px; margin:0 auto; margin-top:50px;"/>
    <form id="form1" runat="server">


               <div class="sag-taraf">

           

         <div class="hizli-kayit">

                    <div class="ust">
                        Admin Girişi
                    </div>

              <div class="alt">

                        <div class="kullanici">
                            <span>Kullanıcı adı</span>
                            <asp:TextBox ID="t1" CssClass="textbox" runat="server"></asp:TextBox>
                        </div>
       
        
         <div class="sifre">
                            <span>Şifre</span>
                            <asp:TextBox ID="t2" CssClass="textbox" TextMode="Password" runat="server"></asp:TextBox>
                        </div>
       
        <br />
        <asp:Button ID="b1" runat="server" CssClass="btnKayit" Text="Login" OnClick="b1_Click" />
        <br />
        <asp:Label ID="l1" runat="server" Text=""></asp:Label>
        <br />

                </div>
                </div>
                </div>
             

   </form>          
    
</body>
</html>
