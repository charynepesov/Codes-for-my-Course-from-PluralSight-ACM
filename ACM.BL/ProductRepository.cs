using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Gets required single product by ID.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>Returns the product.</returns>
        public Product Retrieve(int productId)
        {
            // Create the instance of the Product class
            // Pass the requested Id
            Product product = new Product(productId);

            // Temporary hard-coded values to return
            // a populated product
            if (productId == 2)
            {
                product.CurrentPrice = 15.96M;
                product.ProductDescription = "Assorted size set of 4 Bright Yellow Mini Sunflowers";
                product.ProductName = "SunFlowers";
            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns>True or False</returns>
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an Insert Stored Procedure

                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
