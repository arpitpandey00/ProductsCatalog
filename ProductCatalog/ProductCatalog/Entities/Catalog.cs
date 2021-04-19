using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.OperationOnEntities;

namespace ProductCatalog.Entities
{
    public class Catalog
    {
        public static OperationOnCategory OperationOnCategory { get; set; }
        public OperationOnProducts OperationOnProducts  { get; set; }
        public Catalog()
        {
            Catalog.OperationOnCategory = new OperationOnCategory();
            this.OperationOnProducts = new OperationOnProducts();
        }
        public void DisplayCatalog()
        {
            Console.WriteLine("_______-----Welcome Home-----______");
            Console.WriteLine("\na. Category");
            Console.WriteLine("\nb. Product");
            Console.WriteLine("\nc. Exit");
            var input = Console.ReadLine().ToLower();
            bool exit = false;
            while (exit != true)
            {
                switch (input)
                {
                    case "a":
                        Console.Clear();
                        this.CategoryCatalog();
                        break;
                    case "b":
                        Console.Clear();
                        this.ProductCatalog();
                        break;
                    case "c":
                        exit = true;
                        Console.WriteLine("See You Soon\n Stay Safe");
                        break;
                    default:
                        Console.WriteLine("Invalid Operatoin\nTry Again");
                        Console.Clear();
                        break;
                }
            }
        }
        public void ProductCatalog()
        {
            Console.WriteLine("------- Product Catalog --------\n");
            Console.WriteLine("a. Enter a Product \n");
            Console.WriteLine("b. List all products\n");
            Console.WriteLine("c. Delete a Product(Enter Short Code or ID to delete)\n");
            Console.WriteLine("d. Search a Product(By Id, Name, Short Code, Selling Price Greater than / Less Than / Equal To entered price)\n");
            Console.WriteLine("e. Exit\n");
            var input = Console.ReadLine().ToLower();
            bool Exit = false;
            while (Exit != true)
            {
                this.OperationOnProducts = new OperationOnProducts();
                switch (input)
                {
                    case "a":
                        OperationOnProducts.AddProduct();
                        Console.WriteLine("Want To Add More Product? (y/n)");
                        var sub_Input = Console.ReadLine();
                        if (sub_Input == "n")
                        { Exit = true; }
                        break;
                    case "b":
                        OperationOnProducts.DisplayAllProducts();
                        break;
                    case "c":
                        OperationOnProducts.DeleteAProduct();
                        break;
                    case "d":
                        OperationOnProducts.SearchAProduct();
                        break;
                    case "e":
                        Exit = true;
                        Console.WriteLine("Exiting..............");
                        Console.Clear();
                        this.DisplayCatalog();
                        break;
                    default:
                        Console.WriteLine("Invalid Operation\nTry Again");
                        break;

                }
            }
        }
        public void CategoryCatalog()
        {
            Console.WriteLine("-------- Category Catalog --------\n");
            Console.WriteLine("a. Enter a Category\n");
            Console.WriteLine("b. List all Categories\n");
            Console.WriteLine("c. Delete a Category(Enter Short Code or ID to delete)\n");
            Console.WriteLine("d. Search a Category(By Id, Name or Short Code)\n");
            Console.WriteLine("e. Exit\n");
            var input = Console.ReadLine().ToLower();
            bool Exit = false;
            while(Exit!=true)
            {
            switch(input)
            {
                    case "a":
                        OperationOnCategory.AddCategory();
                        break;
                    case "b":
                        OperationOnCategory.DisplayCategories();
                        break;
                    case "c":
                        OperationOnCategory.DeleteCategory();
                        break;
                    case "d":
                        OperationOnCategory.SearchCategory();
                        break;
                    case "e":
                        Exit = true;
                        Console.WriteLine("Exiting..............");
                        Console.Clear();
                        this.DisplayCatalog();
                        break;
                    default:
                        Console.WriteLine("Invalid Operation\nTry Again");
                        break;

                }
            }
        }
    }
}
