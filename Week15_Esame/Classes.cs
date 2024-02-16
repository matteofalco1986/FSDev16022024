using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week15_Esame
{
    public class Product
    {
        private int _id;
        private string _name;
        private string _brand;
        private string _description;
        private string _imageUrl;
        private double _price;

        public int Id { get { return _id; } set { _id = Id; } }
        public string Name { get { return _name; } set { _name = Name; } }
        public string Brand { get { return _brand; } set { _brand = Brand; } }
        public string Description { get { return _description; } set { _description = Description; } }
        public string ImageUrl { get { return _imageUrl; } set { _imageUrl = ImageUrl; } }
        public double Price { get { return _price; } set { _price = Price; } }

        public Product() { }
        public Product(int id, string name, string brand, string description, string imageUrl, double price)
        {
            _id = id;
            _name = name;
            _brand = brand;
            _description = description;
            _imageUrl = imageUrl;
            _price = price;
        }
    }
    public class ShoppingCart
    {
        public static List<Product> CartProducts = new List<Product>();
        public static double TotalCartAmount = 0;
        public static void SetCartAmount()
        {
            if (ShoppingCart.CartProducts.Count > 0)
            {
                double TotalCart = 0;
                foreach (var item in ShoppingCart.CartProducts)
                {
                    TotalCart += item.Price;
                }
                ShoppingCart.TotalCartAmount = TotalCart;
            }
            else
            {
                ShoppingCart.TotalCartAmount = 0;
            }
        }
    }

    public class Products
    {
        public static List<Product> ProductsAvailable = new List<Product>();
    }
}