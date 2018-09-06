using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lesson_1
{
    public class BinaryGap
    {
        public BinaryGap()
        { }

        public int Solution(int N)
        {
            String binary = Convert.ToString(N, 2);

            int lastPosition = binary.Length - 1;

            while (binary[lastPosition] == '0')
            {
                lastPosition--;
            }

            int counter = 0;
            int maxGap = 0;

            for (; lastPosition >= 0; lastPosition--)
            {
                if (binary[lastPosition] == '1')
                {

                    if (counter > maxGap)
                    {
                        maxGap = counter;
                    }

                    counter = 0;
                }
                else {
                    counter++;
                }
            }

            return maxGap;
        }
    }
}
