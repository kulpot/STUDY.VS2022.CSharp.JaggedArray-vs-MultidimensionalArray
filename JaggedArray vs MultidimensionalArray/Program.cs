using System;

//ref link:https://www.youtube.com/watch?v=3UcJGikWJxs&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL&index=6
// jagged array -- multiple arrays with different length
// rectangular array -- multiple arrays with same length

class MainClass
{
    static void Main()
    {
        //int[] ages = new[] { 25, 27, 23, 34, 36, 99 };
        //int[][] parties = new int[3][];   // jagged array -- multiple arrays with different length
        //parties[0] = new[] { 25, 27, 23, 34, 36, 99 };
        //parties[1] = new[] { 32, 54, 24, 32, 87, 43, 23, 43, 23, 76 };
        //parties[2] = new[] { 23, 25 };
        int[,] parties = new int[3, 6]  // rectangular array -- multiple arrays with same length
        {
            { 25, 27, 23, 34, 36, 99 },
            { 25, 27, 23, 34, 36, 99 },
            { 25, 27, 23, 34, 36, 99 }
        };

    }
}