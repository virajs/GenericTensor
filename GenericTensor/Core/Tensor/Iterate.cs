﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTensor.Core
{
    public partial class Tensor<TWrapper, TPrimitive>
    {
        private void NextIndex(int[] indecies, int id)
        {
            if (id == -1)
                return;
            indecies[id]++;
            if (indecies[id] == Shape[id])
            {
                indecies[id] = 0;
                NextIndex(indecies, id - 1);
            }
        }

        public IEnumerable<(int[] index, TPrimitive value)> Iterate()
        {
            int Sum(int[] arr)
            {
                int s = 0;
                for (int i = 0; i < arr.Length; i++)
                    s += arr[i];
                return s;
            }

            var indecies = new int[Shape.Count];
            do
            {
                yield return (indecies, this[indecies]);
                NextIndex(indecies, indecies.Length - 1);
            } while (Sum(indecies) != 0); // for tensor 4 x 3 x 2 the first violating index would be 5  0  0 
        }
    }
}
