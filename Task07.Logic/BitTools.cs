using System;
using System.Collections.Specialized;

namespace Task07.Logic
{
    public static class BitTools
    {
        /// <summary>
        ///  Method make an insertion of second number in first number from start bit to end bit 
        /// </summary>
        /// <param name="frstNumber"></param>
        /// <param name="scndNumber"></param>
        /// <param name="startBit"> start bit of insertion range</param>
        /// <param name="endBit"> end bit of insertion range</param>
        /// <returns> result of insertion scnd number in first number</returns>
        public static int? BitInsertion(int frstNumber,int scndNumber, int startBit,int endBit)
        {
            if (startBit > endBit || startBit < 0 || endBit < 0 || endBit > 31) { return null; }
            BitVector32 a = new BitVector32(frstNumber);
            BitVector32 b = new BitVector32(scndNumber);
            int maskA = BitVector32.CreateMask();
            int maskB = BitVector32.CreateMask();
            for (int i = 0; i < startBit; i++)
            {
                maskA = BitVector32.CreateMask(maskA);
            }
            
            for (int i = 0; i<= endBit - startBit; i++) 
            {
                a[maskA] = b[maskB];
                maskB = BitVector32.CreateMask(maskB);
                maskA = BitVector32.CreateMask(maskA);
            }

            return a.Data;
        }
    }
}
