using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public override string ToString()
        {
            return $"Name: {ProductName}, Price: {ProductPrice}";
        }
    }
}