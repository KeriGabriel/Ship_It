using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_It
{
    internal class Bicycles : IShippable
    {
        private decimal _shipCost = 20.50M;
        private string _product = "Bicycle";
        public decimal ShipCost
        {
            get
            {
                return _shipCost;
            }
        }
        public string Product
        {
            get { return _product; }
        }
    }
}
