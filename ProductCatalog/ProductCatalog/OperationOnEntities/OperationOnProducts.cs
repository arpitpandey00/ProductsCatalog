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
        OperationOnCategory operationCategory = new OperationOnCategory();
        
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
            Console.WriteLine("Enter category Of Product");
            string category = Console.ReadLine();
            bool iscategoryPresent = false;
            foreach(Category c in OperationOnCategory.categoryList)
            {
                if (c.Name != category)
                    iscategoryPresent = true;                   
            }
            if(iscategoryPresent==true)
            {
                operationCategory.AddCategory();
            }
            ProductsList.Add(new Product
            {
                Name = name,
                Manufacturer = manufacturer,
                Description = description,
                SellingPrice = selllingprice,
                ProductCategory = category
            }) ;
            Console.WriteLine("Product Added succesfully");
        }
        public void DisplayAllProducts()
        {
            Console.WriteLine("Products Are:");
            foreach (Product p in ProductsList)
            {
                Console.WriteLine("Id : " + p.Id + "\nName : " + p.Name + "\nDescription : " + p.Description + "\nShort Code : Null\n\n\n");
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
        public List<Product> ProductGreaterThan = new List<Product>();
        public List<Product> ProductLessThan = new List<Product>();
       
         public void SearchAProduct()
        {
            bool ExitSearch = false;
            while (ExitSearch != true)
            {
                Console.WriteLine("----- Search A Product -----");
                Console.WriteLine("a. By Id");
                Console.WriteLine("b. By Name");
                Console.WriteLine("c. By Selling Price Greater Than");
                Console.WriteLine("d. By Selling Price less Than");
                Console.WriteLine("e. By Selling Price Equal To");
                Console.WriteLine("f. By Name");
                Console.WriteLine("g. Exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.WriteLine("Enter Id To Search");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var Prod = ProductsList.Single(s => id == s.Id);
                        Console.WriteLine("\nID : " + Prod.Id);
                        Console.WriteLine("\nName : " + Prod.Name);
                        Console.WriteLine("\nManufacturer : " + Prod.Manufacturer);
                        Console.WriteLine("\nSelling Price : " + Prod.SellingPrice);
                        Console.WriteLine("\nDescription : " + Prod.Description);
                        Console.WriteLine("Found Succesfully");
                        break;
                    case "b":
                        Console.WriteLine("Enter Name ");
                        string name = Console.ReadLine();
                        var findname = ProductsList.Single(s => name == s.Name);
                        Console.WriteLine("Product Id - " + findname.Id + " Name - " + findname.Name + " Manufacturer - " 
                            + findname.Manufacturer + " Description - " + findname.Description + " Selling Price - " + findname.SellingPrice);
                        break;
                    case "c":
                        Console.WriteLine("Enter Selling Price Greater Than");
                        int InputGreater = Convert.ToInt32(Console.ReadLine());
                        foreach(Product prod in ProductsList)
                        {
                            if (prod.SellingPrice > InputGreater)
                            {
                                this.ProductGreaterThan.Add(prod);
                            }
                        }
                        foreach(Product output in ProductGreaterThan)
                        {
                            Console.WriteLine($"Id : {output.Id}");
                            Console.WriteLine($"Name : {output.Name}");
                            Console.WriteLine($"Manufacturer : {output.Manufacturer}");
                            Console.WriteLine($"Description : {output.Description}");
                            Console.WriteLine($"Selling Price : {output.SellingPrice}");
                        }
                          break;
                        case "d":
                        Console.WriteLine("Enter Selling Price Less Than");
                        int InputLess = Convert.ToInt32(Console.ReadLine());
                        foreach (Product prod in ProductsList)
                        {
                            if (prod.SellingPrice < InputLess)
                            {
                                this.ProductLessThan.Add(prod);
                            }
                        }
                        foreach (Product output1 in ProductLessThan)
                        {
                            Console.WriteLine($"Id : {output1.Id}");
                            Console.WriteLine($"Name : {output1.Name}");
                            Console.WriteLine($"Manufacturer : {output1.Manufacturer}");
                            Console.WriteLine($"Description : {output1.Description}");
                            Console.WriteLine($"Selling Price : {output1.SellingPrice}");
                        }
                         break;
                    case "e":
                        Console.WriteLine("Enter Search Price Equal TO");
                        int Equal = Convert.ToInt32(Console.ReadLine());
                        var PriceEqualsTO = ProductsList.Where(s => s.SellingPrice == Equal).ToList();
                        foreach(Product p in PriceEqualsTO)
                        {
                            Console.WriteLine($"Id : {p.Id}");
                            Console.WriteLine($"Name : {p.Name}");
                            Console.WriteLine($"Manufacturer : {p.Manufacturer}");
                            Console.WriteLine($"Description : {p.Description}");
                            Console.WriteLine($"Selling Price : {p.SellingPrice}");
                        }
                        break;
                        case "f":
                            ExitSearch = true;
                            Console.WriteLine("Exiting..............");
                            Console.Clear();

                            break;
                    case "g":
                        break;
                        default:
                            Console.WriteLine("Invalid Operation\nTry Again");
                            break;

                    }
                
            }

        }
    }
}
