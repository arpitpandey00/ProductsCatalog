using ProductCatalog.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog.OperationOnEntities
{
    public class OperationOnProducts
    {
        public List<Product> ProductsList = new List<Product>{};

         public OperationOnProducts()
        {
            this.ProductsList = new List<Product>();
        }

        public void AddProduct()
        {
            Console.WriteLine("Enter Product Details :");
            Console.WriteLine($"ID : {Product.AutoIncrement}\n");
            Console.WriteLine("Enter Product Name : ");
            string Name = Console.ReadLine();
            Console.WriteLine("\nEnter Manufacturer Name : ");
            string Manufacturer = Console.ReadLine();
            Console.WriteLine("\nEnter Description : ");
            string Description = Console.ReadLine();
            Console.WriteLine("\nEnter Selling Price : ");
            int SelllingPrice = Convert.ToInt32(Console.ReadLine());
            Product newProduct = new Product();
            newProduct.Name = Name;
            newProduct.Manufacturer = Manufacturer;
            newProduct.Description = Description;
            newProduct.SellingPrice = SelllingPrice;
            this.ProductsList.Add(newProduct);
            
        }
        public void DisplayAllProducts()
        {
            Console.WriteLine("Products Are:");
            this.ProductsList.ForEach(prod =>
            { Console.WriteLine(prod); });
        }
        public void DeleteAProduct()
        {
            //(Enter Short Code or ID to delete)
        }
        public void SearchAProduct()
        {
       //(By Id, Name, Short Code, Selling Price Greater than/Less Than/Equal To entered price)

        }
    }
}
