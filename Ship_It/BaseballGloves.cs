using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_It
{
    internal class BaseballGloves : IShippable
    {
        private decimal _shipCost = 3.23M;
        private string _product = " Baseball Glove";
        public decimal ShipCost => _shipCost;
        public string Product => _product;
    }
}
