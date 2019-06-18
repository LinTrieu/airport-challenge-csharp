using System;
using System.Collections.Generic;

namespace airportChallenge
{
    public class Airport
    {
        public int Capacity;
        public List<Object> Hanger;

        public Airport(int capacity = 10) {
            Hanger = new List <Object>();
            Capacity = capacity;
        }

        public void Land(Object plane) {
            Hanger.Add(plane);
        }
        
    }
}
