using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroundTransport
{
    public class Auto : GroundTransport, IBrand
    {
        private int PowerEngine { get; set; }//мощность двигателя
        private int СapacityEngine { get; set; }//объём бака
        public string Brand { get; set; }
        public Auto() { }
        public Auto(string engine, int capacity, string brand)
        {
            Brand = brand;
        }
        
    }
}
