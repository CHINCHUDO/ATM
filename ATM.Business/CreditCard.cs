using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Business
{
    class CreditCard
    {

        private List<int> numbers = new List<int>();

        public List<int> Numbers { get { return numbers; } set { this.numbers = value; } }
    }
}
