using System;

public class Program
{
    static public void Main(string[] args)
    {
        int[] tal1 = new int[5];


        for (int v = 0; v < 5; v++)
        {
            tal1[v] = int.Parse(Console.ReadLine());

        }
        
        for (int v = 4; v >= 0; v--)
        {
            Console.WriteLine(tal1[v]);
        }


    }
}