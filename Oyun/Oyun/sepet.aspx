<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="sepet.aspx.cs" Inherits="Oyun.sepet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <asp:Button ID="b1" runat="server"  Text="Sepeti Görüntüle" OnClick="b1_Click" />
            <asp:DataList ID="d1" runat="server">

                <HeaderTemplate>
                    <table>
                        <tr style="background-color:#bfa828; color:white; font-weight:bold;">
                            <td>Ürün Resmi</td>
                            <td>Oyun Adı</td>
                            <td>Çıkış Yılı</td>
                            <td>Fiyatı</td>
                            <td>Kategorisi</td>
                        </tr>



                </HeaderTemplate>

                <ItemTemplate>
                    <tr>
                        <td><img src="<%#Eval("ImagePath") %>" height="100" width="100" /> </td>
                        <td> <%#Eval("Name") %></td>
                        <td> <%#Eval("Year") %></td>
                        <td> <%#Eval("Price") %></td>
                        <td> <%#Eval("CategoryID") %></td>
                        <td><a href="uruncikart.aspx?id=">Çıkart</a></td>

                      
                        
                    </tr>



                </ItemTemplate>

                <FooterTemplate>
                    </table>
                </FooterTemplate>


            </asp:DataList>
            <br />
            <p align="center">
            <asp:Label ID="l1" runat="server"></asp:Label><br />
            <asp:Button ID="b2" runat="server" Text="Satın Al" OnClick="b2_Click" />
                </p>
        </div>
</asp:Content>