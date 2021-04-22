﻿using ProductCatalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductCatalog.OperationOnEntities
{
    public class OperationOnProducts
    {
        public static List<Product> ProductsList = new List<Product>
        {
           new Product  {
     // Id:1,
      Name="Pen",
      Manufacturer="Natraj",
      Description="Study Material",
      SellingPrice=12,
     // ShortCode:"pn12",
      ProductCategory="Stationary"
    },
    new Product{
     // Id:2,
      Name="Hanger",
      Manufacturer="Maya",
      Description="For Clothes",
      SellingPrice=30,
     // ShortCode:"hg30",
      ProductCategory="Grocery"
    },
    new Product{
      //Id:3,
      Name="Mobile",
      Manufacturer="Oneplus",
      Description="Essintail item",
      SellingPrice=30000,
      //ShortCode:"op30",
      ProductCategory="Technology"
    },
    new Product{
     // Id:4,
      Name="Smart Watch",
      Manufacturer="Mi",
      Description="Health Measuring",
      SellingPrice=10000,
     // ShortCode:"mi10",
      ProductCategory="Technology"
    },
    new Product{
     // Id:5,
      Name="Pencil",
      Manufacturer="Apsara",
      Description="Study Material",
      SellingPrice=7,
      //ShortCode:"pn07",
      ProductCategory="Stationary"
    }
        };
        OperationOnCategory operationCategory = new OperationOnCategory();
        
        public void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter Product Details :\n");
            Console.WriteLine($"ID : {Product.AutoIncrement}\n");
            Console.WriteLine("Enter Product Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter Manufacturer Name : ");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("\nEnter Description : ");
            string description = Console.ReadLine();
            Console.WriteLine("\nEnter Selling Price : ");
            int selllingprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter category Of Product");
            string category = Console.ReadLine();
            bool iscategoryPresent = false;
            foreach(Category c in OperationOnCategory.categoryList)
            {
                if (c.Name.ToLower() == category.ToLower())
                    iscategoryPresent = true;                   
            }
            if(iscategoryPresent==false)
            {
                Console.WriteLine("\nThis category is not Added You Have To Add This Category\n");
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
            Console.WriteLine("Product Added succesfully\n");
            Console.WriteLine("Press Enter TO Continue:");
           
        }
        public void DisplayAllProducts()
        {
            Console.Clear();
            Console.WriteLine("Products Are:");
            foreach (Product p in ProductsList)
            {
                Console.WriteLine("\n\nId : " + p.Id + "\nName : " + p.Name + "\nDescription : " + p.Description + 
                    "\nShort Code : Null\n"+"Category :"+p.ProductCategory+"\nManufacturer :" +p.Manufacturer+
                    "\n Selling Price :"+p.SellingPrice);
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            Console.Clear();

        }
        public void DeleteAProduct()
        {
            //(Enter Short Code or ID to delete)
            Console.Clear();
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
                    case "c":
                        ExitDelete = true;
                        Console.WriteLine("Exiting..............");
                        break;
                    default:
                        Console.WriteLine("Invalid Operation\nTry Again");
                        break;
                }
                Console.WriteLine("Press enter to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public List<Product> ProductGreaterThan = new List<Product>();
        public List<Product> ProductLessThan = new List<Product>();
       
         public void SearchAProduct()
        {
            Console.Clear();
            bool ExitSearch = false;
            while (ExitSearch != true)
            {
                Console.WriteLine("----- Search A Product -----");
                Console.WriteLine("a. By Id");
                Console.WriteLine("b. By Name");
                Console.WriteLine("c. By Selling Price Greater Than");
                Console.WriteLine("d. By Selling Price less Than");
                Console.WriteLine("e. By Selling Price Equal To");
                Console.WriteLine("f. By Short Code");
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
                        break;
                        case "g":
                            ExitSearch = true;
                            Console.WriteLine("Exiting..............");
                            break;
                        default:
                            Console.WriteLine("Invalid Operation\nTry Again");
                            break;

                    }
               
                Console.Clear();

                
            }

        }
    }
}
