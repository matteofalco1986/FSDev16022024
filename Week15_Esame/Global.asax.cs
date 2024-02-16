using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Week15_Esame
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            InitializeProducts();
        }

        protected void InitializeProducts()
        {
            Product Product1 = new Product(
                1,
                "Eco-Friendly Reusable Water Bottle",
                "Ocean",
                "Stay hydrated and environmentally conscious with our 32oz stainless steel, vacuum-insulated water bottle. Keeps drinks cold for up to 24 hours or hot for 12. BPA-free and comes with a leak-proof lid.",
                "https://m.media-amazon.com/images/I/71qBi4zLv3L.jpg",
                29.99);
            Product Product2 = new Product(
                2,
                "Wireless Noise-Cancelling Headphones",
                "Sony",
                "Experience unparalleled sound quality with our wireless headphones. Features active noise cancellation, 35-hour battery life, and a comfortable over-ear design. Bluetooth connectivity for easy device pairing.",
                "https://m.media-amazon.com/images/I/51e598VT1kL._AC_UF350,350_QL80_.jpg",
                199.99);
            Product Product3 = new Product(
                3,
                "Organic Matcha Tea Powder",
                "Heapwell",
                "Sourced from the finest tea gardens in Japan, our organic matcha is perfect for tea, lattes, and baking. Rich in antioxidants and vibrant green in color, our matcha offers a smooth flavor and numerous health benefits",
                "https://m.media-amazon.com/images/I/81qZlPCzZDL._AC_UF1000,1000_QL80_.jpg",
                24.99);
            Product Product4 = new Product(
                4,
                "Smart Fitness Tracker",
                "Fitbit",
                "Keep track of your fitness goals with our sleek and stylish fitness tracker. Monitors heart rate, steps, sleep patterns, and more. Waterproof design and compatible with all smartphones for easy data syncing.",
                "https://images-eu.ssl-images-amazon.com/images/I/61OUFEm2CkL._AC_UL330_SR330,330_.jpg",
                59.99);
            Product Product5 = new Product(
                5,
                "Gourmet Chocolate Assortment Box",
                "Belgian",
                "Indulge in our selection of handmade gourmet chocolates. This assortment box includes a variety of milk, dark, and white chocolates, each filled with exquisite flavors. Perfect for gifting or treating yourself.",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9bsCWd0ZCm1zPXQ5FjAjX7KDk_htvffgmJxnh3La4jDj0pbLqQZx4oPNJ0eEYjM2Y8Ts&usqp=CAU",
                34.99);
            Product Product6 = new Product(
                6,
                "Portable Solar Charger",
                "Mobisolar",
                "Stay charged wherever you go with our portable solar charger. Ideal for camping and outdoor adventures, it's durable, waterproof, and compatible with all smartphones and tablets. Provides up to 2 full charges.",
                "https://m.media-amazon.com/images/I/811YIHVKKaL._AC_UF1000,1000_QL80_.jpg",
                49.99);

            Products.ProductsAvailable.Add(Product1);
            Products.ProductsAvailable.Add(Product2);
            Products.ProductsAvailable.Add(Product3);
            Products.ProductsAvailable.Add(Product4);
            Products.ProductsAvailable.Add(Product5);
            Products.ProductsAvailable.Add(Product6);
        }
    }
}