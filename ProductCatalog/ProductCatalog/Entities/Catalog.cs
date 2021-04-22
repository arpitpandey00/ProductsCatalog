﻿using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.OperationOnEntities;

namespace ProductCatalog.Entities
{
    public class Catalog
    {
      OperationOnCategory operationOnCategory = new OperationOnCategory();
       OperationOnProducts operationOnProducts = new OperationOnProducts();
        public void DisplayCatalog()
        {
           
            //var input = Console.ReadLine().ToLower();
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine("_______-----Welcome Home-----______");
                Console.WriteLine("\na. Category");
                Console.WriteLine("\nb. Product");
                Console.WriteLine("\nc. Exit");

                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.Clear();
                        this.CategoryCatalog();
                        exit = true;
                        break;
                    case "b":
                        Console.Clear();
                        this.ProductCatalog();
                        exit = true;
                        break;
                    case "c":
                        exit = true;
                        Console.WriteLine("See You Soon\n Stay Safe");
                        break;
                    default:
                        Console.WriteLine("Invalid Operatoin\nTry Again");
                        break;
                }
            }
        }
        public void ProductCatalog()
        {
            
            //var input = Console.ReadLine().ToLower();
            bool ExitProduct = false;
            while (ExitProduct != true)
            {
                Console.WriteLine("------- Product Catalog --------\n");
                Console.WriteLine("a. Enter a Product \n");
                Console.WriteLine("b. List all products\n");
                Console.WriteLine("c. Delete a Product(Enter Short Code or ID to delete)\n");
                Console.WriteLine("d. Search a Product(By Id, Name, Short Code, Selling Price Greater than / Less Than / Equal To entered price)\n");
                Console.WriteLine("e. Exit\n");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        operationOnProducts.AddProduct();
                        break;
                    case "b":
                        try
                        {
                        operationOnProducts.DisplayAllProducts(); 
                        }
                        catch(Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("No Products Avaliable");
                            Console.WriteLine("Press Enter For Main Menu");
                            Console.ReadKey();
                            Console.Clear();
                            this.DisplayCatalog();
                        }
                        break;
                    case "c":
                        try
                        {
                            operationOnProducts.DeleteAProduct();
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Products Not Avaliable Or Already Deteted");
                            Console.WriteLine("Press Enter For Main Menu");
                            Console.ReadKey();
                            Console.Clear();
                            this.DisplayCatalog();
                        }
                        break;
                    case "d":
                        try
                        {
                            operationOnProducts.SearchAProduct();
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Products Not Avaliable of this kind");
                            Console.WriteLine("Press Enter For Main Menu");
                            Console.ReadKey();
                            Console.Clear();
                            this.DisplayCatalog();
                        }
                        
                        break;
                    case "e":
                        ExitProduct = true;
                        Console.WriteLine("Exiting..............");
                        Console.Clear();
                        this.DisplayCatalog();
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
        public void CategoryCatalog()
        {
            bool ExitCategory = false;
            while(ExitCategory!=true)
            {
                Console.WriteLine("-------- Category Catalog --------\n");
                Console.WriteLine("a. Enter a Category\n");
                Console.WriteLine("b. List all Categories\n");
                Console.WriteLine("c. Delete a Category(Enter Short Code or ID to delete)\n");
                Console.WriteLine("d. Search a Category(By Id, Name or Short Code)\n");
                Console.WriteLine("e. Exit\n");
                switch (Console.ReadLine().ToLower())
            {
                    case "a":
                        operationOnCategory.AddCategory();
                        break;
                    case "b":
                        try
                        {
                        operationOnCategory.DisplayCategories();
                        }
                        catch(Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("No category Avaliable");
                            Console.WriteLine("Press Enter For Main Menu");
                            Console.ReadKey();
                            Console.Clear();
                            this.DisplayCatalog();
                        }
                        break;
                    case "c":
                        try
                        {
                            operationOnCategory.DeleteCategory();
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("No category Avaliable or Already Deleted");
                            Console.WriteLine("Press Enter For Main Menu");
                            Console.ReadKey();
                            Console.Clear();
                            this.DisplayCatalog();
                        }
                        break;
                    case "d":
                        try
                        {
                            operationOnCategory.SearchCategory();
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("No category Avaliable of this kind");
                            Console.WriteLine("Press Enter For Main Menu");
                            Console.ReadKey();
                            Console.Clear();
                            this.DisplayCatalog();
                        }
                        break;
                    case "e":
                        ExitCategory = true;
                        Console.WriteLine("Exiting..............");
                        Console.Clear();
                        this.DisplayCatalog();
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
    }
}
