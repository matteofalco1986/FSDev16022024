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
            string htmlContent = "";
            foreach (var item in Products.ProductsAvailable)
            {
                htmlContent += $@"<div class=""col"">
                                    <div class=""card"">
                                        <img class=""card-img-top"" src=""{item.ImageUrl}"" alt=""{item.Name}"">
                                        <div class=""card-body"">
                                            <h5 class=""card-title"">{item.Name}</h5>
                                            <h6 class=""card-text"">{item.Brand}</h6>
                                            <p class=""card-text"">{item.Price} &euro;</p>
                                        </div>
                                    </div>
                                </div>";
            }

            ProductsList.InnerHtml = htmlContent;
        }
        protected void DetailClick(int id)
        {
            Response.Redirect($"/Detail.aspx?productId={id}");
        }
    }
}