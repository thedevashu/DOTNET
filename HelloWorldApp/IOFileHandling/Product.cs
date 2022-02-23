using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOFileHandling
{
    [Serializable]//write this to serilize the object 
    public class Product
    {
        public string PName { get; set; }
        public int Cost { get; set; }
        public string Desc { get; set; }
        public int Quantity { get; set; }
    }
}
