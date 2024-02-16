using System;
using System.Collections.Generic;
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
            string htmlContent = "";
            for (int i = 0; i < ShoppingCart.CartProducts.Count; i++)
            {
                htmlContent += $@"<div class=""col"">
                                                <div class=""card"">
                                                    <img class=""card-img-top"" src=""{ShoppingCart.CartProducts[i].ImageUrl}"" alt=""{ShoppingCart.CartProducts[i].Name}"">
                                                    <div class=""card-body"">
                                                        <h5 class=""card-title"">{ShoppingCart.CartProducts[i].Name}</h5>
                                                        <h6 class=""card-text"">{ShoppingCart.CartProducts[i].Brand}</h6>
                                                        <p class=""card-text"">{ShoppingCart.CartProducts[i].Price} &euro;</p>
                                                    </div>
                                                </div>
                                            </div>";
            }
            foreach (var item in ShoppingCart.CartProducts)
            {
                Response.Write(item.Name);

            }

            CartList.InnerHtml = htmlContent;
        }
        protected void BackToHomeClick(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}