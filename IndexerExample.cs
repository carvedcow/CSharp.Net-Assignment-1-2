using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.NetAssignment1_2
{
    class IndexerExample
    {
        private int[] val = new int[2];

        public int this[int i]
        {
            get
            {
                return val[i];
            }
            set
            {
                val[i] = value;
            }
        }
    }
}
