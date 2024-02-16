using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week15_Esame
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShoppingCart.SetCartAmount();
            LblCartAmount.Text = $"Totale: {ShoppingCart.TotalCartAmount} &euro;";
            if (!IsPostBack)
            {
                IndexRepeater.DataSource = Products.ProductsAvailable;
                IndexRepeater.DataBind();
            }
            if (ShoppingCart.CartProducts.Count == 0)
            {
                LblCartCount.Text = $"Nessun articolo";

            }
            else if (ShoppingCart.CartProducts.Count == 1)
            {
                LblCartCount.Text = $"{ShoppingCart.CartProducts.Count} Articolo";
            }
            else
            {
                LblCartCount.Text = $"{ShoppingCart.CartProducts.Count} Articoli";
            }

        }

        protected void DetailClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string argument = btn.CommandArgument;
            Response.Redirect($"Detail.aspx?productId=" + argument);
        }
        protected void GoToCartClick(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }
    }
}