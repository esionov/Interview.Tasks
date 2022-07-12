using System;
using System.Linq;
using System.Threading.Tasks;

namespace test1
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var items = Enumerable.Range(0, 100);
            var sum = 0;
            foreach (var item in items)
            {
                sum += await ProcessAsync(item);
            }

            Console.WriteLine($"Sum is {sum}");
        }
        
        private static async Task<int> ProcessAsync(int val)
        {
            Console.WriteLine($"Processing {val}");
            await Task.Delay(TimeSpan.FromSeconds(5));
            return val * 5;
        }
    }
}