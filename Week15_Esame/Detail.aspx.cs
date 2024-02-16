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
        Product CurrentProduct;
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
                    CurrentProduct = Products.ProductsAvailable.Find(item => item.Id == productId);
                    htmlContent = $@"<div class=""card"">
                                            <img class=""card-img-top"" src=""{CurrentProduct.ImageUrl}"" alt=""{CurrentProduct.Name}"">
                                            <div class=""card-body"">
                                                <h5 class=""card-title"">{CurrentProduct.Name}</h5>
                                                <h6 class=""card-text"">{CurrentProduct.Brand}</h6>
                                                <p class=""card-text"">{CurrentProduct.Description} &euro;</p>
                                                <p class=""card-text"">{CurrentProduct.Price} &euro;</p>
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

        }
        protected void AddToCartClick(object sender, EventArgs e)
        {

        }
    }
}