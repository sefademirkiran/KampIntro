﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //Ürünlerle ilgili operasyonlar
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(" Güncellendi.");
        }
       
    }
}
