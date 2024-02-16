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
            if (!IsPostBack)
            {
                IndexRepeater.DataSource = Products.ProductsAvailable;
                IndexRepeater.DataBind();
            }
            LblCartCount.Text = $"{ShoppingCart.CartProducts.Count} ITEMS";
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