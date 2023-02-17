using System;

namespace Arrays
{
    public class StringChecker
    {
        static public void Main(String[] args)
        {

            string inputS = Console.ReadLine();
            string inputP1 = Console.ReadLine();
            string inputP2 = Console.ReadLine();
            List<string> result = new List<string>();
            int p = 0;
            int t = 0;
            for (int i = 0; i < inputS.Length; i++) 
            {
                if (inputS[i] == inputP1[p])
                {
                    result.Add(inputP1[p].ToString());
                    if (p < inputP1.Length - 1)
                    {
                        p++;
                    }
                }
                if (inputS[i] == inputP2[t])
                {
                    result.Add(inputP2[t].ToString());
                    if (t < inputP2.Length - 1)
                    {
                        t++;
                    }
                }
            }
            string s = string.Join("", result);
            if (s == inputS && (inputP1.Length + inputP2.Length == inputS.Length))
            {
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("different");
            }

        }
    }
}
/*TASK  Is it possible to create one array S from 2 arrays P1 and P2?
The condition is for arrays P1 P2 to be organized in the same order as S array.
Exmpl:        int[] stringS = new int[7];
            stringS[0] = 'r';
            stringS[1] = 'a';
            stringS[2] = 'd';
            stringS[3] = 'e';
            stringS[4] = 'n';
            stringS[5] = 'c';
            stringS[6] = 'y';
            int[] pi1 = new int[4];
            pi1[0] = 'r';
            pi1[1] = 'd';
            pi1[2] = 'n';
            pi1[3] = 's';
            int[] pi2 = new int[3];
            pi2[0] = 'a';
            pi2[1] = 'e';
            pi2[2] = 'y';*/