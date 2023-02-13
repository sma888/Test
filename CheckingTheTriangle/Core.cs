using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingTheTriangle
{
    public class Core
    {
        public bool ExistTest(double a, double b, double c)
        {
            if ((a + b > c && a + c > b && b + c > a) && (a > 0 && b > 0 && c > 0))
            {
                return true;
            }
            else return false;
        }
    }
}
