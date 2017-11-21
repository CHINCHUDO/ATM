using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Business
{
    public class CheckingAccount : Account
    {
        public new void Withdraw(double withdraw)
        {
            if (withdraw > 500.0) throw new WithdrawUpTo500Exception();

            base.Withdraw(withdraw);
        }
    }
}
