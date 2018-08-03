using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace 商场管理软件
{
    class CashContext
    {
        private CashSuper cs;

        public void setBehavior(string className, object[] args)
        {
            this.cs = (CashSuper)Assembly.Load("商场管理软件").CreateInstance("商场管理软件." + className, false, BindingFlags.Default, null, args, null, null);
        }

        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}
