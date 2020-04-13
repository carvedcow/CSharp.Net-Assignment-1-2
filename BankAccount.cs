using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.NetAssignment1_2
{
    struct BankAccount
    {
        // values
        typeOfAccount typeofaccount { get; set; }
        public float depositAmount { get; set; }

        //constructor (no default constructor allowed)
        public BankAccount(typeOfAccount accType, float depAmount)
        {
            typeofaccount = accType;
            depositAmount = depAmount;
    }
    }
}
