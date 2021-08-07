using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroundTransport
{
    public class Moto : GroundTransport, IBrand
    {
        private int PowerEngine { get; set; }//мощность двигателя
        private int СapacityEngine { get; set; }//объём бака
        public string Brand { get; set; }
        public Moto() { }
        public Moto(string engine, int capacity, string brand)
        {
            Brand = brand;
        }
    }
}
