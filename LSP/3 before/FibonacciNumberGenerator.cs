using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP._3_before
{
   public class FibonacciNumberGenerator
    {
        public int GetNumberAt(int positionInSequence)
        {
            if (positionInSequence<2)
            {
                return positionInSequence;
            }
            return GetNumberAt(positionInSequence - 1)
                + GetNumberAt(positionInSequence - 2);

        }

        public virtual int[] GetSequenceOfLength(int length)
        {
            int[] sequence = new int[length];

            for (int index = 0; index < length; index++)
            {
                sequence[index] = GetNumberAt(index);

            }
            return sequence;
        }
       
    }
}
