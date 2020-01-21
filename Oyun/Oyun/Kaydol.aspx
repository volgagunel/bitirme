<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kaydol.aspx.cs" Inherits="Oyun.Kaydol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kaydol</title>

    <link href="/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div style="width: 285px; margin: 0 auto; margin-top: 50px;">

        <div class="sag-taraf">

            <asp:Panel ID="pnlKayit" runat="server">

         <div class="hizli-kayit">

                    <div class="ust">
                        Hızlı Kaydol
                    </div>

                    <div class="alt">

                        <div class="kullanici">
                            <span>Kullanıcı adı</span>
                            <asp:TextBox ID="txtKullaniciAdi" CssClass="textbox" runat="server" />
                        </div>

                        <div class="sifre">
                            <span>Şifre</span>
                            <asp:TextBox ID="txtSifre" CssClass="textbox" runat="server" TextMode="Password" />
                        </div>

                        <a href="/" class="btnGiris">İptal</a>
                        <asp:Button ID="btnKayit" runat="server" CssClass="btnKayit" Text="Kaydet"  OnClick="btnKayit_Click"/>
                        <asp:Label ID="lblSonuc" Text="" runat="server" />

                    </div>
                </div>

                </asp:Panel>

            <asp:Panel ID="pnlDurum" runat="server" Style="background-color: #fff; padding: 10px;">
                <asp:Label ID="lblDurum" Text="" runat="server" />
                <br />
                <a href="/">Anasayfaya Dönmek için tıklayınız.</a>
            </asp:Panel>
            </div>
        </div>
    </form>
</body>
</html>
