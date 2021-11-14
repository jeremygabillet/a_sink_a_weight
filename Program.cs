using System;
using System.Threading.Tasks;

namespace a_sink_a_weight
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            Random random = new Random();
            int rnd1 = random.Next(1000, 5000);
            int rnd2 = random.Next(1000, 5000);
            
            await Task.Delay(rnd1);
            await Task.Delay(rnd2);
            Console.WriteLine($"Task rnd1 executed in {rnd1} milliseconds.");
            Console.WriteLine($"Task rnd2 executed in {rnd2} milliseconds.");
            return 0;
        }
    }
}
