using Codility.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson 1, Binary Gap
            BinaryGap gap = new BinaryGap();
            gap.Solution(1041);
            gap.Solution(15);
            gap.Solution(32);

            //Lesson 2, Cyclic Rotation
            CyclicRotation cyc = new CyclicRotation();
            int[] cycA = { 33, 8, 9, 7, 6 };
            int cycK = 3;
            cyc.Solution(cycA, cycK);

        }
    }
}
