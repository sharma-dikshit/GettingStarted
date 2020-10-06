using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalMathematicalOperations
{
    public interface IAddition
    {
        int SumTwoNumbers(int x, int y);
    }
    public class Addition : IAddition
    {
        public int SumTwoNumbers(int x, int y)
        {
            return x + y;
        }
    }
}
