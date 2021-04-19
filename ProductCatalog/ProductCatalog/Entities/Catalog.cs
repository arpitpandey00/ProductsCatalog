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

        }
        public void CategoryCatalog()
        {

        }
    }
}
