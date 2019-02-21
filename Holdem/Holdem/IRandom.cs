using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holdem
{
    public interface IRandom
    {
        int Next(int startingMin, int includingMax);
    }
}
