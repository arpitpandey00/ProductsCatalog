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
                        this.ProductCatalog();
                        break;
                    case "b":
                        Console.Clear();
                        this.CategoryCatalog();
                        break;
                    case "c":
                        exit = true;
                        Console.WriteLine("See You Soon\n Stay Safe");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Operatoin\nTry Again");
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
                switch (input)
                {

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

            }
            }
        }
    }
}
