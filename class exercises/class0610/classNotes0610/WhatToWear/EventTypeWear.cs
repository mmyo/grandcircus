using System;
using System.Collections.Generic;
using System.Text;

namespace WhatToWear
{
    public class EventTypeWear
    {
        public Dictionary<Enum, string> EventTypeDicionary { get; set; }


        public EventTypeWear()
        {
            EventTypeDicionary = new Dictionary<Enum, string>();
            EventTypeDicionary.Add(EventEnum.Casual, "comfy");
            EventTypeDicionary.Add(EventEnum.SemiFormal, "polo");
            EventTypeDicionary.Add(EventEnum.Formal, "suit");

        }

        public string PickMyEventClothes(Enum eventType)
        {
            return EventTypeDicionary[eventType];
        }
    }
}
