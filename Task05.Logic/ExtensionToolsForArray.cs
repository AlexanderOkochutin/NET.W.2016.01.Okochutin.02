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
        /// <exception >
        /// when data array length less than 3, throw ArgumentException()
        /// </exception>
        public static int IndexOfEquilibriumFinder(this int[] data)
        {
            int equIndex = -1;
            long leftSum, rightSum = 0;
            if (data.Length < 3)
            {
                throw new ArgumentException(nameof(data) + " must have length more than 3");
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
