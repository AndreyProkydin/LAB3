using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab3
{
    internal class Buble : Container
    {
        public double[] numArray { get; set; }


        public override void Sort()
        {
            var n = numArray.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (numArray[j] > numArray[j + 1])
                    {
                        var tempVar = numArray[j];
                        numArray[j] = numArray[j + 1];
                        numArray[j + 1] = tempVar;
                    }

            //return numArray;
        }
        public override void Foreach()
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = Math.Sqrt(numArray[i]);
            }
        }
    }
}
