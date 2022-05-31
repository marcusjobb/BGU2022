using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFU02_01
{
    public class Product
    {
        public double Pris { get; set; }
        public string Namn { get; set; }
        public Product(string namn, double pris)
        {
            Namn = namn;
            Pris = pris;
        }

        public override string ToString()
        {
            return $"{{{nameof(Pris)}={Pris.ToString()}, {nameof(Namn)}={Namn}}}";
        }
    }
}
