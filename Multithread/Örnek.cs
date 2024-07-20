using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithread
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            // Thread oluşturma ve başlatma
            Thread thread1 = new Thread(new ThreadStart(Method1));
            Thread thread2 = new Thread(new ThreadStart(Method2));

            thread1.Start();
            thread2.Start();

            // Ana thread'in bitmesini bekleyin
            thread1.Join();
            thread2.Join();

            Console.WriteLine("Both threads have completed.");
        }

        static void Method1()
        {
            for (int i = 5; i < 10; i++)
            {
                Console.WriteLine($"Method1 is processing {i + 1}");
                Thread.Sleep(500); // Simulate work
            }
        }
        static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Method2 is processing {i + 1}");
                Thread.Sleep(500); // Simulate work
            }
        }
    }
}
