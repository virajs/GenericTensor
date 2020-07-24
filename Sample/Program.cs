﻿#region copyright
/*
 * MIT License
 * 
 * Copyright (c) 2020 WhiteBlackGoose
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
#endregion

using GenericTensor;
using System;
using GenericTensor.Core;
using GenericTensor.Functions;
using System.Linq;

namespace Sample
{
    class Program
    { 
        static void Main(string[] args)
        {
            BuiltinTypeInitter.InitForFloat();
            var A = GenTensor<float>.CreateMatrix(
            new float[,]{
                {6, 1, 1},
                {4, -2, 5},
                {2, 8, 7}
            });
            var B = A.Copy(true);
            Console.WriteLine(A);
            A.InvertMatrix();
            Console.WriteLine();
            Console.WriteLine(A);
            Console.WriteLine();
            Console.WriteLine(GenTensor<float>.MatrixDotProduct(A, B));
        }
    }
}
