using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_It
{
    internal class Crackers : IShippable
    {
        private decimal _shipCost = 0.57M;
        private string _product = " Crackers";
        public decimal ShipCost => _shipCost;
        public string Product => _product;
    }
}
