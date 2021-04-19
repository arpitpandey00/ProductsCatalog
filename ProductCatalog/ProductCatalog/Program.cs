using ProductCatalog.Entities;
using System;

namespace ProductCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Catalog catalog = new Catalog();
            catalog.DisplayCatalog();
        }
    }
}
