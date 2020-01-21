<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="siparisdetay.aspx.cs" Inherits="Oyun.siparisdetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table>
        <tr>
            <td>İsim :</td>
            <td><asp:TextBox ID="t1" runat="server"></asp:TextBox></td>
        </tr>
                <tr>
            <td>Soyisim :</td>
            <td><asp:TextBox ID="t2" runat="server"></asp:TextBox></td>
        </tr>
                <tr>
            <td>Şehir :</td>
            <td><asp:TextBox ID="t3" runat="server"></asp:TextBox></td>
        </tr>
                <tr>
            <td>Adres:</td>
            <td><asp:TextBox ID="t4" runat="server" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="b1" runat="server" Text="Devam Et" OnClick="b1_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
