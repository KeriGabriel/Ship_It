using System;
using System.Collections.Generic;

namespace Ship_It
{
     class Shipper
    {
        public static List<IShippable> _shippingList = new List<IShippable>();

        public static int _bikeCount = 0;
        public static int _BaseballGloveCount = 0;
        public static int _LawnmowerCount = 0;
        public static int _crackersCount = 0;

        private static decimal _totalShipping;
        private static string _bicycleName = SetName(new Bicycles());
        private static string _BaseballGloveName = SetName(new BaseballGloves());
        private static string _lawnmowerName = SetName(new LawnMower());
        private static string _crackersName = SetName(new Crackers());
        public static decimal AddTotal()
        {
            _totalShipping = 0;
            int length=_shippingList.Count;
            for (int i = 0; i < length; i++)
            {
                _totalShipping += _shippingList[i].ShipCost;
            }
            return _totalShipping;
        }
        private static string SetName(IShippable item)
        {
            return item.Product;
        }
       public static string ShippingManifest()
        {
            string manifest = "Shipment manifest: \n"
                + ManufestConvert(_bikeCount, _bicycleName)
                + ManufestConvert(_BaseballGloveCount, _BaseballGloveName)
                + ManufestConvert(_LawnmowerCount, _lawnmowerName)
                + ManufestConvert(_crackersCount, _crackersName);
            return manifest;
        }
         private static  string ManufestConvert(int count, string name)
          {
            if (count > 1)
            {
                name = name+"s";
            }            
            return "\n"+ count + name;
           }       
    }
}
