using System;
using System.Collections.Generic;
using System.Threading.Tasks;
public class PrimeNumber
{


    public static async Task<bool> CheckPrime(int n)
    {
        Task<bool> checkPrime = new Task<bool>(
            () =>
            {
                for (int i = 2; i < n; i++)
                    if (n % i == 0)
                        return false;
                return true;

            }
        );
        checkPrime.Start();
        var result = await checkPrime;
        return result;
    }

    public static async Task<List<int>> GetPrimeListAsync(int min, int max)
    {
        List<int> primeList = new List<int>();
        for (int i = min; i <= max; i++)
        {
            if (await CheckPrime(i))
            {
                primeList.Add(i);
                //Console.Write(i + " ");
            }
        }
        return primeList;
    }
    static void Main(string[] args)
    {
        int min, max;
        Console.Write("Enter the min number : ");
        min = int.Parse(Console.ReadLine());
        Console.Write("Enter the max number: ");
        max = int.Parse(Console.ReadLine());
        //Console.Write("Price number: ");

        Task<List<int>> primeList = GetPrimeListAsync(min, max);
        var count = GetPrimeListAsync(min, max).Result.Count;
        // var kq = await primeList;
        // Console.WriteLine(kq);
        Console.WriteLine($"Number of prime: {count} ");

        // List<int> primeList = GetPrimeListAsync(min, max);
        // Console.WriteLine();
        // Console.Write($"Number of prime: {primeList.Count} ");
    }
}