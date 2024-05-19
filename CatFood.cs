using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class CatFood : Product
    {
        public bool KittenFood { get; set; }
        public string Brand { get; set; }
        public override string ToString()
        {
            return base.ToString() + $", Brand: {Brand}, Is kitten Food: {KittenFood}";
        }
    }

}