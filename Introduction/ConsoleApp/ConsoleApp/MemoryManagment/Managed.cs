using ConsoleApp.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.MemoryManagment
{
    internal class Managed
    {
        // ASCI Code 97 'a' and 65 'A' 
        static readonly char[] alphabets = Enumerable.Range(97, 25)
            .Select(x => (char)x)
            .Concat(Enumerable.Range(65, 25)
            .Select(x => (char)x))
            .ToArray();

        public void Loop()
        {
            int count = Random.Shared.Next(0, int.MaxValue);
            Console.WriteLine($"Loop will run for {count}");
            for (int i = 0; i < count; i++)
            {
                long n = Random.Shared.NextInt64(long.MaxValue);
                Console.WriteLine($"Index {i} and value {n}");
            }
        }
        public void LoopString(ReadOnlySpan<char> chars, System.Threading.CancellationToken cancellation)
        {
            int count = Random.Shared.Next(0, int.MaxValue);
            Console.WriteLine($"Loop will run for {count}");
           
            for (int i = 0; i < count; i++)
            {
                int x = Random.Shared.Next(14);
                chars = Enumerable.Range(0, x).Select(x => alphabets[Random.Shared.Next(0, alphabets.Length)]).ToArray();
                string str = new(chars);
                Console.WriteLine($"Index {i} and value {str}");
                if(cancellation.IsCancellationRequested)
                {
                    break;
                }
            }
        }
        public void LoopRef()
        {
            int count = Random.Shared.Next(0, int.MaxValue);
            for (int i = 0; i < count; i++)
            {
                var obj = new Car("2022", "Civic", "2022", new Engine(), () => (4, 17, 30), 4);
                Console.WriteLine($"Index {i} and value {obj}");
            }
        }
    }
}
