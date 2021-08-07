using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroundTransport
{
    public abstract class GroundTransport
    {
        public string Engine { get; set; }
        public int Capacity { get; set; }//я здесь имел ввиду по вместимостью сколько людей помешается

        protected GroundTransport() { }
        protected GroundTransport(string engine, int capacity) 
        {
            Engine = engine;
            Capacity = capacity;
        }
    }
}
