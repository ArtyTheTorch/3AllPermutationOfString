using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3AllPermutationOfString
{
    class RecursivePermutation
    {
        static char[] str;
        static string results;

        public RecursivePermutation(string p)
        {
            // TODO: Complete member initialization
            str = p.ToCharArray();
            results = "";

        }

        internal string getResults()
        {
            bool[] used = new bool[str.Length];
            permute(0, results, used);
            return results;
        }

        static void permute(int level, string permuted, bool[] used)
        {
            int length = str.Length;
            if(level == length){
                results += permuted + "\n";
            }
            else{
                for (int i =0; i < length; i++)
                {
                    if(!used[i]){
                        used[i] = true;
                        permute(level + 1, permuted + str[i], used);
                        used[i] = false;
                    }
                }
            }
        }
    }
}
