using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectorprogram
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
                double F13 = 6.67 * Math.Pow(10, -11) * 6 * Math.Pow(10, 24) * 7 * Math.Pow(10, 22);
                double F14 = (Math.Sqrt(2) * 6.67 * Math.Pow(10, -11) * 6 * Math.Pow(10, 24) * 7 * Math.Pow(10, 22));
                double Ftotxy = F13 + F14;
                Vector vt = new Vector(Ftotxy, Ftotxy);

            
        }
    }
 }

