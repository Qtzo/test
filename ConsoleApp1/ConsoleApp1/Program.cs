  
using System;

namespace HelloWorld
{
    class Program
    {

        class Solution
        {
            public string solution(string S, string T)
            {
                if (S.Length >= 100 || T.Length >= 100) return "ERROR";
                if (S == T) return "EQUAL";
                if (Math.abs(S.Length - T.Length) > 1) return "IMPOSSIBLE";
                if (S.Length > T.Length)
                {
                    for (int j = 0; j < T.Length; j++)
                    {
                        if (S[j] != T[j])
                            if (S[j + 1] != T[j])
                                return "IMPOSSIBLE";
                            else return "INSERT " + S[j];

                    }
                    return "INSERT " + S[S.Length - 1];

                }
                else if (S.Length < T.Length)
                {
                    for (int j = 0; j < S.Length; j++)
                    {
                        if (T[j] != S[j])
                            if (T[j + 1] != S[j])
                                return "IMPOSSIBLE";
                            else return "INSERT " + T[j];

                    }
                    return "INSERT " + T[T.Length - 1];
                }
                List<int> count = new List<int>();
                for (int i = 0; i < S.Length; i++)
                {
                    if (T[i] != S[i])
                        count.Add(i);
                }
                if(count.Count == 1) return "REPLACE " + T[count[0]] + " " + S[count[0]];
                else if (count.Count == 2 && T[count[0]] == S[count[1]]) return "SWAP " + T[count[0]] + " " + S[count[0]];
                return "IMPOSSIBLE";
            }


        }

  
        static void Main(string[] args)
        {

            Solution a = new Solution();
            Console.WriteLine(a.solution("asa", "aas"));
        }
    }
}
