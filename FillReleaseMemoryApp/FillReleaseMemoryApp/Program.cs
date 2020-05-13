using System;
using System.Threading.Tasks;

namespace FillReleaseMemoryApp
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {

                var array = new double[100000000];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = i;
                }

                Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                Console.WriteLine("*");

            } while (true);
        }
    }
}
