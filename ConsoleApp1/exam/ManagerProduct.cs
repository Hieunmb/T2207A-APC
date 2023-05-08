using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.exam
{
    public class ManagerProduct
    {
        private List<Product> products= new List<Product>();
        public void AddProduct()
        {
            // Khởi tạo một sinh viên mới
            Product sv = new Product();
            Console.Write("Product ID: ");
            sv.ProductId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Product Name: ");
            sv.Productname = Console.ReadLine();

            Console.Write("Price: ");
            sv.price = Convert.ToDouble(Console.ReadLine());



            products.Add(sv);
        }
        public void ShowProduct(List<Product> products)
        {
            // hien thi tieu de cot
            Console.WriteLine("Product ID \t Prodcut Name \t Price");
            // hien thi danh sach sinh vien
            if (products != null && products.Count > 0)
            {
                foreach (Product sv in products)
                {
                    Console.WriteLine(sv.ProductId + " \t\t\t" + sv.Productname + " \t " + sv.price);
                }
            }
            Console.WriteLine();
        }
        private Product FindProductByID(int id)
        {
            Product productFind = null;
            if (products != null && products.Count > 0)
            {
                foreach (Product product in products)
                {
                    if (product.ProductId == id)
                    {
                        productFind = product;
                    }
                }
            }
            return productFind;
        }
        public void DeleteProduct(int id)
        {
            Product st = FindProductByID(id);
            if (st != null)
            {
                products.Remove(st);
            }
            else
            {
                Console.WriteLine("Sinh vien co ID = " + id + " khong ton tai.");
            }
        }
        public List<Product> getListProduct()
        {
            return products;
        }
    }
}
