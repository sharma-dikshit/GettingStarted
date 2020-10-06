using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalMathematicalOperations
{
    public interface ISubstraction
    {
        int SubstractTwoNumbers(int x, int y);
    }
    public class Substraction : ISubstraction
    { 
        public int SubstractTwoNumbers(int x, int y)
        {
            return x - y;
        }
    }
}
