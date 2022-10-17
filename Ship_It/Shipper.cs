﻿using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Ship_It
{
     class Shipper
    {
        private static List<IShippable> _shippingList = new List<IShippable>();

        private static int _bikeCount = 0;
        private static int _BaseballGloveCount = 0;
        private static int _LawnmowerCount = 0;
        private static int _crackersCount = 0;
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
            SetProductCount();
            string manifest = "Shipment manifest: \n"
                + ManufestConvert(_bikeCount, _bicycleName)
                + ManufestConvert(_BaseballGloveCount, _BaseballGloveName)
                + ManufestConvert(_LawnmowerCount, _lawnmowerName)
                + "\n" + _crackersCount + _crackersName;
            return manifest;
        }
        private static string ManufestConvert(int count, string name)
          {
            if (count > 1)
            {
                name = name+"s";
            }            
            return "\n"+ count + name;
           }       
        public static void AddToList(IShippable item)
        {
            _shippingList.Add(item);
        }
        private static int CountItemInList(List<IShippable> myList, string CountName)
        {
            int count = 0;
            foreach (IShippable item in myList)
                if (item.Product == CountName)
                    count++;
            return count;
        }
        private static void SetProductCount()
        {
           _bikeCount = CountItemInList(_shippingList, _bicycleName);
           _LawnmowerCount = CountItemInList(_shippingList, _lawnmowerName);
           _crackersCount = CountItemInList(_shippingList, _crackersName);
           _BaseballGloveCount = CountItemInList(_shippingList, _BaseballGloveName);
        }
     }
}
