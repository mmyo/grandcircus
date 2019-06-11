using System;
using System.Collections.Generic;
using System.Text;

namespace WhatToWear
{
    public class TemperatureWear
    {
        public Dictionary<Enum, string> TemperatureWearDictionary { get; set; }

        public TemperatureWear()
        {
            TemperatureWearDictionary = new Dictionary<Enum, string>();
            TemperatureWearDictionary.Add(TempEnum.LessThan54, "coat");
            TemperatureWearDictionary.Add(TempEnum.Between55And69, "jacket");
            TemperatureWearDictionary.Add(TempEnum.GreaterThan70, "no jacket");

        }

        public string PickMyClothesBasedOnTemp(Enum tempEnum)
        {
            return TemperatureWearDictionary[tempEnum];
        
        }
    }
}
