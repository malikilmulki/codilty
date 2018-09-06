using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons
{
    public class CyclicRotation
    {
        public CyclicRotation()
        { }

        public int[] Solution(int[] A, int K)
        {
            int size = A.Length - 1;

            if (size <= 0)
            {
                return A;
            }

            for (int count = 1; count <= K; count++)
            {

                int lastValue = A[size];

                for (int i = 0; i <= size - 1; i++)
                {
                    A[size - i] = A[size - (i + 1)];
                }

                A[0] = lastValue;
            }
            return A;
        }
    }
}
