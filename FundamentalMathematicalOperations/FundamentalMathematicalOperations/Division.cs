using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalMathematicalOperations
{
    public interface IDivision
    {
        double DivideTwoNumbers(int x, int y);
    }
    public class Division : IDivision
    {
        public double DivideTwoNumbers(int x, int y)
        {
            return x / y;
        }
    }


}
