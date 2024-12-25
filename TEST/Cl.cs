using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
  
    public class Cl
    { 
        public bool Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("НЕЛЬЗЯ ДЕЛИТЬ НА 0");
            }

            if (a % b == 0)
                return true;
            else return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
