﻿using ProductCatalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductCatalog.Validations;

namespace ProductCatalog.OperationOnEntities
{
    public class OperationOnCategory
    {
        
        public static List<Category> categoryList = new List<Category>
        {              
                new Category
                {
                    Name="Grocery",
                    Description="Necessary Items",
                    ShortCode="gr00"
                },
                new Category
                {
                    Name="Food",
                    Description="Daily accomodation",
                    ShortCode="fd01"
                },
              new Category   {
       Name="Technology",
    Description= "Gadgets",
    ShortCode="Tech"
  },
  new Category{
    
    Name="Grocery",
    Description="Household Items",
    ShortCode="Groc"
  },
  new Category{
       Name="Toys",
    Description= "For Kids",
    ShortCode="tykd"
  },
  new Category{
        
    Name="Stationary",
    Description= "Study",
    ShortCode="stud"
  },
        };

        ShortCodeValidation shortcodevalidation = new ShortCodeValidation();
        public void AddCategory()
        {
            Console.Clear();
            Console.WriteLine("Enter Category Details :");
            //Console.WriteLine($"ID : {Category.AutoIncrement}\n");
            Console.WriteLine("Enter New Category Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter Description : ");
            string description = Console.ReadLine();
            Console.WriteLine("\nEnter Short Code : ");
            string shortCode = shortcodevalidation.ShortCodeValidatingCategory();
            categoryList.Add(new Category
            {
                Name = name,
                Description = description,
                ShortCode = shortCode
            }) ;
            Console.WriteLine("New Catogery Added succesfully");
            // Console.WriteLine("Press enter to continue");
            //Console.ReadKey();

        }
       public void DisplayCategories()
        {
            Console.Clear();
            Console.WriteLine("Catogriess Are:");
            foreach (Category category in categoryList)
            {
                //Console.WriteLine("\nId : " + c.Id + "\nName : " + c.Name + "\nDescription : " + c.Description + "\nShort Code : Null\n");
                Console.WriteLine(category.ToString());            
            }
            Console.ReadKey();
            Console.WriteLine("Press enter to continue");
            Console.Clear();

        }
        public void DeleteCategory()
        {
            Console.Clear();
            bool ExitDelete = false;
            while (ExitDelete != true)
            {
                Console.WriteLine("----- Deleting Category");
                Console.WriteLine("a. Delete by Name");
                Console.WriteLine("b. Delete by Id ");
                Console.WriteLine("c. Delete by Short Code ");
                Console.WriteLine("d. Exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.WriteLine("Enter Name : ");
                        string inputName = Console.ReadLine();
                        Category findname = categoryList.Single(single => inputName == single.Name);
                        categoryList.Remove(findname);
                        OperationOnProducts.ProductsList.RemoveAll(finding => finding.ProductCategory == inputName);
                        Console.WriteLine("Removed Successfully");
                        break;
                    case "b":
                        Console.WriteLine("Enter Id : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var findid = categoryList.Single(single => id == single.Id);
                        categoryList.Remove(findid);
                        OperationOnProducts.ProductsList.RemoveAll(finding => finding.ProductCategory == findid.Name);
                        Console.WriteLine("Removed Successfully");
                        break;
                    case "c":
                        Console.WriteLine("Enter Short Code : ");
                        string ShortCode = Console.ReadLine();
                        Category findshortcode = categoryList.Single(single => ShortCode == single.ShortCode);
                        categoryList.Remove(findshortcode);
                        OperationOnProducts.ProductsList.RemoveAll(finding => finding.ProductCategory == findshortcode.Name);
                        Console.WriteLine("Removed Successfully");
                        break;
                    case "d":
                        ExitDelete = true;
                        Console.WriteLine("Exiting..............");
                        break;
                    default:
                        Console.WriteLine("Invalid Operation\nTry Again");
                        Console.ReadKey();
                        break;
                }

                Console.WriteLine("Press enter to continue");
                Console.Clear();
            }


        }
        public void SearchCategory()
        {
            Console.Clear();
            bool ExitSearch = false;
            while (ExitSearch != true)
            {
                Console.WriteLine("----- Search A Product -----");
                Console.WriteLine("a. By Id");
                Console.WriteLine("b. By Name");
                Console.WriteLine("c. By Short Code");
                Console.WriteLine("d. Exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.WriteLine("Enter Id To Search");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var category = categoryList.Single(single => id == single.Id);
                        //Console.WriteLine("\nID : " + Products.Id);
                        //Console.WriteLine("\nName : " + Products.Name);
                        //Console.WriteLine("\nDescription : " + Products.Description);
                        Console.WriteLine(category.ToString());
                        //Console.WriteLine("Found Succesfully");
                        break;
                    case "b":
                        Console.WriteLine("Enter Name ");
                        string name = Console.ReadLine();
                        var findname = categoryList.Single(single => name == single.Name);
                        //Console.WriteLine("Product Id - " + findname.Id + " Name - " + findname.Name + " Description - " + findname.Description);
                        Console.WriteLine(findname.ToString());
                        break;
                    case "c":
                        Console.WriteLine("Enter Short Code To Search");
                        string ShortCode = Console.ReadLine();
                        var findcategory = categoryList.Single(single => ShortCode == single.ShortCode);
                        //Console.WriteLine("\nID : " + Products.Id);
                        //Console.WriteLine("\nName : " + Products.Name);
                        //Console.WriteLine("\nDescription : " + Products.Description);
                        Console.WriteLine(findcategory.ToString());
                        Console.WriteLine("Found Succesfully");
                        break;
                    case "d":
                        ExitSearch = true;
                        Console.WriteLine("Exiting..............");
                        Console.Clear();

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
