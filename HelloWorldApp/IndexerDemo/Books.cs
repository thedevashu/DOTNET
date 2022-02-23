using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    public class BookLib
    {
        private string[] Book= new string[6];

        public string this[int index]
        {
            get { return Book[index]; }
            set { Book[index] = value; }
        }
    }
}
