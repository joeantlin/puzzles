using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static void Main(string[] args)
        {
            // System.Console.WriteLine(RandomArray());
            // System.Console.WriteLine(TossCoin());
            List<string> nameslist = new List<string>();
            nameslist.Add("Todd");
            nameslist.Add("Tiffany");
            nameslist.Add("Charlie");
            nameslist.Add("Geneva");
            nameslist.Add("Sydney");
            System.Console.WriteLine(Names(nameslist));
            // System.Console.WriteLine(nameslist[0]);
        }
        private static Random random1 = new Random();
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();  
            return random.Next(min, max); 
        }
        public static int[] RandomArray()
        {
            int[] newArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                newArray[i] = RandomNumber(1, 26);
            }
            int sum = 0;
            int min = newArray[0];
            int max = newArray[0];
            for (int i = 1; i <newArray.Length; i++)
            {
                sum += newArray[i];
                if (newArray[i] > max)
                {
                    max = newArray[i];
                }
                if (newArray[i] < min)
                {
                    min = newArray[i];
                }
            }
            Console.WriteLine($"Min: {min} Max: {max} Sum: {sum}");
            return newArray;
        }
        public static string TossCoin()
        {
            int result = RandomNumber(1, 3);
            System.Console.WriteLine("Flipping a coin");
            if (result == 2)
            {
                return "Heads";
            } else {
                return "Tails";
            }
        }
        public static string Names(List<string> names)
        {
            int n = names.Count;
             while (n > 1)
             {
                n--;
                int k = random1.Next(n + 1);
                System.Console.WriteLine(k);
                string value = names[k];
                names[k] = names[n];
                names[n] = value;
            }
            return $"{names[0]}, {names[1]}, {names[2]}, {names[3]}, {names[4]}";
            // return names;
        }
    }
}
