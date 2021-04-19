using ProductCatalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductCatalog.OperationOnEntities
{
    public class OperationOnProducts
    {
        public static List<Product> ProductsList = new List<Product>();
        public void AddProduct()
        {
            Console.WriteLine("Enter Product Details :");
            Console.WriteLine($"ID : {Product.AutoIncrement}\n");
            Console.WriteLine("Enter Product Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter Manufacturer Name : ");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("\nEnter Description : ");
            string description = Console.ReadLine();
            Console.WriteLine("\nEnter Selling Price : ");
            int selllingprice = Convert.ToInt32(Console.ReadLine());
            ProductsList.Add(new Product
            {
                Name = name,
                Manufacturer = manufacturer,
                Description = description,
                SellingPrice = selllingprice
            });
            Console.WriteLine("Product Added succesfully");
        }
        public void DisplayAllProducts()
        {
            Console.WriteLine("Products Are:");           
               foreach(Product p in ProductsList)
                {
                    Console.WriteLine("Id : "+p.Id+"\nName : "+p.Name+"\nDescription : "+p.Description+"\nShort Code : Null\n\n\n");
                }
           
        }
        public void DeleteAProduct()
        {
            //(Enter Short Code or ID to delete)
            bool ExitDelete = false;
            while (ExitDelete != true)
            {
                Console.WriteLine("----- Deleting Product");
                Console.WriteLine("a. Delete by Short Code");
                Console.WriteLine("b. Delete by Id ");
                Console.WriteLine("c. Exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        break;
                    case "b":
                        Console.WriteLine("Enter Id : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var findid = ProductsList.Single(s => id == s.Id);
                        ProductsList.Remove(findid);
                        Console.WriteLine("Removed Successfully");
                        ExitDelete = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Operation\nTry Again");
                        break;
                }
            }
        }
        public void SearchAProduct()
        {
            //(By Id, Name, Short Code, Selling Price Greater than/Less Than/Equal To entered price)
            bool ExitSearch = false;
            while (ExitSearch != true)
            {
                Console.WriteLine("----- Search A Product -----");
                Console.WriteLine("a. By Id");
                Console.WriteLine("b. By Short Code");
                Console.WriteLine("c. By Selling Price Greater Than");
                Console.WriteLine("d. By Selling Price less Than");
                Console.WriteLine("e. By Selling Price Equal To");
                Console.WriteLine("f. Exit");
                //var input = Console.ReadLine().ToLower();       
                // this.OperationOnProducts = new OperationOnProducts();
                    switch (Console.ReadLine().ToLower())
                    {
                        case "a":
                        Console.WriteLine("Enter Id To Search");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var Prod = ProductsList.Single(s => id == s.Id);
                        Console.WriteLine("\nID : "+Prod.Id);
                        Console.WriteLine("\nName : "+Prod.Name);
                        Console.WriteLine("\nManufacturer : " + Prod.Manufacturer);
                        Console.WriteLine("\nSelling Price : " + Prod.SellingPrice);
                        Console.WriteLine("\nDescription : " + Prod.Description);
                        Console.WriteLine("Found Succesfully");
                        break;
                        case "b":

                            break;
                        case "c":

                            break;
                        case "d":

                            break;
                        case "f":
                            ExitSearch = true;
                            Console.WriteLine("Exiting..............");
                            Console.Clear();

                            break;
                        default:
                            Console.WriteLine("Invalid Operation\nTry Again");
                            break;

                    }
                
            }

        }
    }
}
