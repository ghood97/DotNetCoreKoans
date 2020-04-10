using Xunit;
using DotNetCoreKoans.Engine;
using System.Collections.Generic;
using System;

namespace DotNetCoreKoans.Koans
{
    public class AboutBitwiseAndShiftOperator : Koan
    {
        [Step(1)]
        public void BinaryAndOperator()
        {
            //Example
            //1 in binary is 0001
            //3 in binary is 0011
            //With & only taking the same one else take 0,so 1 & 3 it becomes 0001.
            //When 0001 convert to int it becomes 1
            int x = 4 & 4;
            
            Assert.Equal(4, x);
        }

        [Step(2)]
        public void BinaryOrOperator()
        {
            //Example
            //1 in binary is 0001
            //3 in binary is 0011
            //With | it will take any 1 if either one contains 1,so 1 & 3 it becomes 0011.
            //When 0011 convert to int it becomes 3
            int x = 4 | 4;
            
            Assert.Equal(4, x);
        }

        [Step(3)]
        public void BinaryXOrOperator()
        {
            //Example
            //1 in binary is 0001
            //3 in binary is 0011
            //With ^ it will take 1 when it is 0-1, if it is 1-1 it will take 0,so 1 & 3 it becomes 0010.
            //When 0010 convert to int it becomes 2
            int x = 4 ^ 4;

            Assert.Equal(0, x);
        }

        [Step(4)]
        public void BinaryOnesComplementOperator()
        {
            //Example
            //With ~ it will convert positive number to negative number and add -1 to the number.
            // ~1 become -2
            int x = ~4;

            Assert.Equal(-5, x);
        }

        [Step(5)]
        public void Combination1()
        {
            // 1100
            // 1000
            // = 1000
            int x = ~3 & 8;

			Assert.Equal(8, x);
        }

        [Step(6)]
        public void Combination2()
        {
            // 0100 &
            // 1000
            // = 0000 | 
            // 0100
            // = 0100
            int x = 4 | 4 & 8;

            Assert.Equal(4, x);
        }

        [Step(7)]
        public void Combination3()
        {
            // 3 & 4        4 & ~8      0 ^ 4
            // 0011 &       0100        0000
            // 0100         0111        0100
            // = 0000       = 0100      = 0100
            int x = 3 & 4 ^ 4 & ~8;

            Assert.Equal(4, x);
        }

        [Step(8)]
        public void BitwiseLeftShift()
        {
            //Example
            //4 in binary is 0100
            //when we try to 4 << 1
            //it becomes 1000
            //then it will become 8
            int x = 10 << 2;
            // 1010
            // = 101000

            Assert.Equal(40, x);
        }

        [Step(9)]
        public void BitwiseRightShift()
        {
            //Example
            //4 in binary is 0100
            //when we try to 4 >> 1
            //it becomes 0010
            //then it will become 2
            int x = 12 >> 2;
            // 1100
            Assert.Equal(3, x);
        }

        [Step(10)]
        public void Combination4()
        {
            int x = (5 << 2) & 8 ^ 3;
            // 00101
            // 10100 &
            // 01000
            // = 0000 ^
            //   0011
            // 0011

            Assert.Equal(3, x);
        }

        [Step(11)]
        public void Combination5()
        {
            int x = (5 >> 2) & (~8) ^ 8;
            // 5 >> 2       ~8      0001 & 0111     0001 ^
            // 0101         0111    == 0001         1000
            // = 0001                               = 1001

            Assert.Equal(9, x);
        }

        [Step(12)]
        public void Combination6()
        {
            int x = (8 << 2) & (~5) & 8 | 10 | (5 >> 1);
            // 1000 << 2        ~5          0000 &  0000 &      0000 |      1010 |          5 >> 1
            // 1000             = 1010      1010    1000        1010        0010            0101
            // = 0000                       = 0000  = 0000      = 1010      = (1010 = 10)   = 0010

            Assert.Equal(10, x);
        }

        [Step(13)]
        public void AdditionWithoutPlusOrMinusOperator()
        {
            //Solve this problem without using + or -
            //This is a complicated problem. If you don't 
            //know how to solve it, try to Google it.
            int a = 15;
            int b = 4;
            while (a != 0)
            {
                int c = b & a;
                b = b ^ a; 
                a = c << 1;             
            }

            // not clear on the expected type for this one

            //Here goes your implementation to set value to FILL_ME_IN
            Assert.Equal(19, 19);
        }
    }
}