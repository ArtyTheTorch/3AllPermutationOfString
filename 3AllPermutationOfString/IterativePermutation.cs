using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3AllPermutationOfString
{
    class IterativePermutation
    {
        private char[] str;

        public IterativePermutation(string str)
        {
            // TODO: Complete member initialization
            this.str = str.ToCharArray();
        }

        internal string getResults()
        {
            var temp = str;
            string results = "";

            for (int i = 0; i < str.Length; i++) {
                //temp = new ArraySegment<char>(str, i, str.Length - i);
                results += new string(temp) + '\n';
            }

                return results;
        }
    }
}
