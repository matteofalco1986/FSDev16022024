using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week15_Esame
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CartRepeater.DataSource = ShoppingCart.CartProducts;
                CartRepeater.DataBind();
            }
            if (ShoppingCart.CartProducts.Count == 0)
            {
                string htmlContent = "";
                htmlContent = "<h2 class='text-center'>Il carrello e' vuoto</h2>";
                PageContainer.InnerHtml = htmlContent;
            }
        }
        protected void BackToHomeClick(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
        protected void DeleteArticle(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string argument = btn.CommandArgument;
            Product ItemToFind = ShoppingCart.CartProducts.Find(item => item.Id == int.Parse(argument));
            int index = ShoppingCart.CartProducts.IndexOf(ItemToFind);
            ShoppingCart.CartProducts.RemoveAt(index);
            Response.Redirect("Cart.aspx");
        }
        protected void EmptyCartClick(object sender, EventArgs e)
        {
            ShoppingCart.CartProducts.Clear();
            Response.Redirect("Cart.aspx");

        }
    }
}