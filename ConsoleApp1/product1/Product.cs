using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace T2207A.product1
{
    public class Product
    {
        private int ProductID;
        private string ProductName;
        private double Price;
        public int ProductId
        {
            get { return ProductID; }
            set { ProductID = value; }
        }
        public string Productname
        {
            get { return ProductName; }
            set { ProductName = value; }
        }
        public double price
        {
            get { return Price; }
            set { Price = value; }
        }
        public Product()
        {

        }
        public Product(int ProductID, string ProductName, double Price)
        {
            ProductId = ProductID;
            Productname = ProductName;
            price = Price;
        }
    }
}
