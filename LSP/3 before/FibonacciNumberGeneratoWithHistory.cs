using System;

namespace LSP._3_before
{
    public class FibonacciNumberGeneratoWithHistory: FibonacciNumberGenerator
    {

        int _lastSequenceLength = 0;

        public int GetLastSequenceLength() => _lastSequenceLength;

        public override int[] GetSequenceOfLength(int length)
        {
            if (length<8 || length>50)
            {
                throw new ArgumentOutOfRangeException();

            }
            _lastSequenceLength = length;
            return base.GetSequenceOfLength(length);
        }

    }
}
