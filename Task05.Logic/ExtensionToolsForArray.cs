using System;

namespace Task05.Logic
{
    /// <summary>
    ///   Extension of array functionality
    /// </summary>
    /// 
    public static class ExtensionToolsForArray
    {
 
        /// <param name="data"> array of int's elements </param>
        /// <returns> Index of element where sum of the numbers on the right side and on the left side of it are equal 
        ///           index in case of success
        ///           -2 if array length less than 3
        ///           -1 if index of equilibrium not finded
        /// </returns>
         
        public static int IndexOfEquilibriumFinder(int[] data)
        {
            int equIndex = -1;
            int incorrectData = -2;
            long leftSum, rightSum = 0;
            if (data.Length < 3)
            {
                return incorrectData;
            }

            leftSum = data[0];

            for (int ptr = 2; ptr < data.Length; ptr++)
            {
                rightSum += data[ptr];
            }

            for (int pointer = 1; pointer < data.Length - 1; pointer++)
            {
                if (leftSum == rightSum)
                {
                    return pointer;
                }

                leftSum += data[pointer];
                rightSum -= data[pointer + 1];
            }
            return equIndex;
        }   
    }
}
