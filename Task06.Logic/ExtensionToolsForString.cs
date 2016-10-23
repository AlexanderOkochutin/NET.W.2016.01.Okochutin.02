using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task06.Logic
{
    public static class ExtensionToolsForString
    {
        /// <summary>
        /// Method which make union and sort of two input strings using LINQ, elements are a-z or A-Z 
        /// </summary>
        /// <param name="fstString"> first input string </param>
        /// <param name="scndString"> second input string </param>
        /// <returns>string received from union and sort of two input strings</returns>
        public static string UnionAndSortLINQ(string fstString, string scndString)
        {
            string pattern = @"^[A-Za-z]+$";
            Regex regex = new Regex(pattern);
            Match match1 = regex.Match(fstString);
            Match match2 = regex.Match(scndString);
            if (match1.Success && match2.Success)
            {
                var rstString = (from s in fstString.Union(scndString) orderby s select s).ToArray();
                return new string(rstString);
            }
            else
            {

                return "check input information!";

            }
            
        }

     
    }
}
