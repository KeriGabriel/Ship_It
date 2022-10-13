using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_It
{
    internal class LawnMower : IShippable
    {
        private decimal _shipCost = 24.00M;
        private string _product = " Lawn Mower";
        public decimal ShipCost => _shipCost;      
        public string Product => _product;        
    }
}
