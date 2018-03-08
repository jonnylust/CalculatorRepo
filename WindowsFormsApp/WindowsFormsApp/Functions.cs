using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class Functions
    {
        //kalhdajsdlah
        public String Add(double inp1, double inp2)
        {
            return (inp1 + inp2).ToString();
        }

        public String Sub(double inp1, double inp2)
        {
            return (inp1 - inp2).ToString();
        }

        public String div(double inp1, double inp2)
        {
            return (inp1 / inp2).ToString();
        }

        public String Mult(double inp1, double inp2)
        {
            return (inp1 * inp2).ToString();
        }

        public String exp(double inp1)
        {
            return Math.Pow(inp1, 2).ToString();
        }

        public String SquareRoot(double inp1)
        {
            return Math.Sqrt(inp1).ToString();
        }
    }
}
