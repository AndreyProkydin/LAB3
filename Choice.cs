using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Choice : Container
    {
        public double[] numArray1 { get; set; }

        public override void Sort()
        {
            int n = numArray1.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numArray1[j] < numArray1[minIndex])
                    {
                        minIndex = j;
                    }
                }

                var temp = numArray1[minIndex];
                numArray1[minIndex] = numArray1[i];
                numArray1[i] = temp;
            }
            //return numArray;
        }
        
        public override void Foreach()
        {
            for (int i = 0; i < numArray1.Length; i++)
            {
                numArray1[i] = Math.Log(numArray1[i]);
         
            }
        }

        
    }
}
