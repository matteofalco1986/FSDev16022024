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
        private string _description;
        private string _imageUrl;
        private double _price;

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public string ImageUrl { get { return _imageUrl; } }
        public double Price { get { return _price; } }
        
        public Product()
        {

        }
        public Product(int id, string name, string description, string imageUrl, double price)
        {
            _id = id;
            _name = name;
            _description = description;
            _imageUrl = imageUrl;
            _price = price;
        }
    }

    public class ShoppingCart
    {
        public List<Product> ProductsList = new List<Product>();
    }
}