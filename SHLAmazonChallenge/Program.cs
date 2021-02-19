using System;

namespace SHLAmazonChallenge
{
    public class Program
    {
        public int[] cellCompete(int[] states, int days)
        {
            int[] retstates = new int[states.Length];
            // INSERT YOUR CODE HERE
            for (int y = 0; y < days; y++)
            {
                for (int x = 0; x < states.Length; x++)
                {
                    int before;
                    int after;
                    if (x == 0)
                    {
                        before = 0;
                        after = states[x + 1];
                    }
                    else if ( x == states.Length - 1)
                    {
                        after = 0;
                        before = states[x - 1];
                    }
                    else
                    {
                        before = states[x - 1];
                        after = states[x + 1];
                    }

                    if((before == 0 && after == 0) || (before == 1 && after == 1))
                    {
                        retstates[x] = 0;
                    }
                    else
                    {
                        retstates[x] = 1;
                    }
                }
                retstates.CopyTo(states,0);
            }

            return states;
        }

        public int generalizedGCD(int num, int[] arr)
        {
            //Buscamos el mínimo
            int min = arr[0];
            for(int x = 0; x< num; x++)
            {
                if (arr[x] < min)
                    min = arr[x];
            }

            int res = 1;
            //Verificamos si se puede dividir
            while (true)
            {
                for (int x = 0; x < num; x++)
                {
                    res = arr[x] % min;

                    if (res != 0)
                        break;
                }

                if (res == 0)
                    break;

                min -= 1;

            }


            return min;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            //int[] states = { 1, 1, 1, 0, 1, 1, 1, 1 };
            //p.cellCompete(states, 2);
            int[] input = { 2, 4, 6, 8, 10 };
            p.generalizedGCD(5, input);


            
        }
    }
}
