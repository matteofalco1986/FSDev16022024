<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Week15_Esame.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <h1 class="text-center p-4">SHOPPING CART</h1>
    <div class="container p-4">
        <div class="row row-cols-1 row-cols-sm-2 row-cols-md-3 row-cols-lg-4 row-cols-xl-6" id="CartList" runat="server">
            <asp:Repeater ID="CartRepeater" runat="server">
                <ItemTemplate>
                    <div class="col">
                        <div class="card">
                            <img class="card-img-top p-2" src='<%# Eval("ImageUrl") %>' alt='<%# Eval("Name") %>'>
                            <div class="card-body">
                                <h5 class="card-title"><%# Eval("Name") %></h5>
                                <h6 class="card-text">'<%# Eval("Brand") %>'</h6>
                                <p class="card-text"><%# Eval("Price") %> &euro;</p>
                                <asp:Button ID="BtnDelete" runat="server" Text="Elimina dal carrello" OnClick="DeleteArticle" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-danger" />
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <div class="d-flex justify-content-center">
        <asp:Button ID="BtnToHome" runat="server" Text="Back to Home Page" CssClass="btn btn-primary gx-3 m-3" OnClick="BackToHomeClick" />
        <asp:Button ID="BtnEmptyCart" runat="server" Text="Emtpy Cart" CssClass="btn btn-danger m-3" OnClick="EmptyCartClick" />

    </div>


</asp:Content>
