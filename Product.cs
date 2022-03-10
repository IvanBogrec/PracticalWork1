using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork1
{
    class Product
    {
        public string PrName { get; set; }
        public string PrCipher { get; set; }
        public int PrNumber { get; set; }

        public Product() { }

        public Product(string PrName, string PrCipher, int PrNumber)
        {
            PrName = this.PrName;
            PrCipher = this.PrCipher;
            PrNumber = this.PrNumber;
        }
    }
}
