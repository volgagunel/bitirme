<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="ps4oyunlari.aspx.cs" Inherits="Oyun.ps4oyunlari" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <asp:DataList ID="d2" RepeatColumns="3" CellPadding="2" runat="server">
        <HeaderTemplate>
            <style>
                img{
                    padding:0;
                    max-height:100%;
                    min-width:100%;
                    margin-left:20px;
                    margin-right:20px;
                }
            </style>
            
            <ul>

            </ul>
        </HeaderTemplate>
        <ItemTemplate>
            <div style=" width:120px; height:120px;">
            <a href="urungoster.aspx?id=<%#Eval("ProductID") %>"><img src="../<%#Eval("ImagePath")%>" alt="" /></a>
                </div>
            <h3><%#Eval("Name") %></h3>
            <h4>Çıkış Yılı:<%#Eval ("Year") %></h4>
            <h4>Kategori:<%#Eval ("SubCategoryName") %></h4>
            <h4>Ücreti:₺<%#Eval ("Price") %></h4>

        </ItemTemplate>
    </asp:DataList>

</asp:Content>
