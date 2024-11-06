using System.ComponentModel;

//Its base and height are both equal to n. It is drawn using # symbols and spaces. The last line is not preceded by any spaces.
//Write a program that prints a staircase of size n.


class Result
{
    public static void staircase(int n)
    {
        String e = " ";
        String s = "#";
        int d = 1;
        int x = 0;
        int y = 0;

        for (int i = 0; i < n; i++)
        {
            x = n - d;
            y = d;
            while (x > 0)
            {
                Console.Write(e);
                x--;
            }
            while (y > 0)
            {
                Console.Write(s);
                y--;
            }
            d++;
            Console.WriteLine();
        }

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
