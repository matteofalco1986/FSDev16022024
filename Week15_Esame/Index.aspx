<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Week15_Esame.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="page-container p-4">
        <h1 class="text-center mb-3">HOME PAGE</h1>
        <div class="container">
            <div class="d-flex align-items-center">
                <asp:Button ID="BtnToCart" runat="server" Text="Carrello" CssClass="btn btn-primary d-flex justify-content-end mb-3" OnClick="GoToCartClick" />
                <asp:Label ID="LblCartCount" runat="server" Text="" CssClass="btn btn-light mb-3 mr-2"></asp:Label>
            </div>

            <div class="row row-cols-1 row-cols-sm-2 row-cols-md-3 row-cols-lg-4 row-cols-xl-5" id="ProductsList" runat="server">
                <asp:Repeater ID="IndexRepeater" runat="server">
                    <ItemTemplate>
                        <div class="col mb-3">
                            <div class="card">
                                <img class="card-img-top" src='<%# Eval("ImageUrl") %>' alt='<%# Eval("Name") %>'>
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Name") %></h5>
                                    <h6 class="card-text">'<%# Eval("Brand") %>'</h6>
                                    <p class="card-text"><%# Eval("Price") %> &euro;</p>
                                    <asp:Button ID="BtnDettagli" runat="server" Text="Dettagli" OnClick="DetailClick" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-success" />
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>

</asp:Content>
