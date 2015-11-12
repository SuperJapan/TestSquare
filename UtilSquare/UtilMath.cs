using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilSquare
{
    public class UtilMath
    {
        public const string ArgumentIsEqualToZeroMessage = "Argument is zero";
        public const string ArgumentLessThanZeroMessage = "Argument less than zero";

        public static double getSquareTriangle(double a, double b)
        {
		if (a < 0 || b < 0)
		{
			throw new ArgumentOutOfRangeException((a < 0 ? "a" : "b"), (a < 0 ? a : b), ArgumentLessThanZeroMessage);
		}
		else if (a == 0 || b == 0)
		{
            throw new ArgumentOutOfRangeException((a == 0 ? "a" : "b"), (a == 0 ? a : b), ArgumentIsEqualToZeroMessage);
		}
		
            return (a * b) / 2;
        }

    }
}
