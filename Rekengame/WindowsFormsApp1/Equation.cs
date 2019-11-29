using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum SomSoort
    {
        Plus,
        Minus,
        Multiply,
        Divide,
    };


class Equation
    {
        public SomSoort SomSoort { get; private set; }
    }


}
