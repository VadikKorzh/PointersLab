using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Pointers
{
    struct Point3d
    {
        public int X;
        public int Y;
        public int Z;

        public override string ToString()
        {
            return $"[{X}, {Y}, {Z}]";
        }
    }
}
