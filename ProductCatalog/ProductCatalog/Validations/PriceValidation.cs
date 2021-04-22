using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog.Validations
{
    public class PriceValidation
    {
        public int PriceValidating()
        {
            int ProductPrice=0;
          try
            {
                ProductPrice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Price should be a number and greater than 0");
                Console.WriteLine("\nEnter Price Again : ");
                PriceValidating();
             }         
           return ProductPrice;
    }
        }
}
