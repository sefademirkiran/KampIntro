using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //Birim Fiyatı
        public int UnitInStock { get; set; } //Stok Adedi
        public int MyProperty { get; set; }

    }
}
