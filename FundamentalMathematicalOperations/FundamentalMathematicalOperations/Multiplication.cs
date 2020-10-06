using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalMathematicalOperations
{
    public interface IMultiplication
    {
        int MultiplyTwoNumbers(int x, int y);
    }
    public class Multiplication : IMultiplication
    {
        public int MultiplyTwoNumbers(int x, int y)
        {
            return x * y;
        }
    }
}
