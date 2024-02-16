using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week15_Esame
{
    public partial class Detail : System.Web.UI.Page
    {
        int productId;
        Product ProductToDisplay;
        string htmlContent = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.Parse(Request.QueryString["productId"]) > Products.ProductsAvailable.Count())
                {
                    Response.Redirect("NotFound.aspx");

                }
                else if (Request.QueryString["productId"] != null)
                {
                    productId = int.Parse(Request.QueryString["productId"]);
                    ProductToDisplay = Products.ProductsAvailable.Find(item => item.Id == productId);
                    htmlContent = $@"<div class=""card"">
                                            <img class=""card-img-top"" src=""{ProductToDisplay.ImageUrl}"" alt=""{ProductToDisplay.Name}"">
                                            <div class=""card-body"">
                                                <h5 class=""card-title"">{ProductToDisplay.Name}</h5>
                                                <h6 class=""card-text"">{ProductToDisplay.Brand}</h6>
                                                <p class=""card-text"">{ProductToDisplay.Description} &euro;</p>
                                                <p class=""card-text"">{ProductToDisplay.Price} &euro;</p>
                                            </div>
                                        </div>";
                    DetailContainer.InnerHtml = htmlContent;
                }
            }
        }

        protected void BackToHomeClick(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void DeleteFromCartClick(object sender, EventArgs e)
        {
            ShoppingCart.CartProducts.Remove(ShoppingCart.CartProducts.Find(item => item.Id == int.Parse(Request.QueryString["productId"])));
        }
        protected void AddToCartClick(object sender, EventArgs e)
        {
            Product CurrentProduct = new Product(
                Products.ProductsAvailable.Find(item => item.Id == int.Parse(Request.QueryString["productId"])).Id,
                Products.ProductsAvailable.Find(item => item.Id == int.Parse(Request.QueryString["productId"])).Name,
                Products.ProductsAvailable.Find(item => item.Id == int.Parse(Request.QueryString["productId"])).Brand,
                Products.ProductsAvailable.Find(item => item.Id == int.Parse(Request.QueryString["productId"])).Description,
                Products.ProductsAvailable.Find(item => item.Id == int.Parse(Request.QueryString["productId"])).ImageUrl,
                Products.ProductsAvailable.Find(item => item.Id == int.Parse(Request.QueryString["productId"])).Price
            );
            ShoppingCart.CartProducts.Add(CurrentProduct);
        }
        protected void GoToCartClick(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }
    }
}