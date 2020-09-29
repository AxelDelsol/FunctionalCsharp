using System;

namespace FunctionalCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<short, short> addOne = (short x) => (short) (x + 1);
            Func<int, int> multiplyByTwo = (int x) => 2 * x;

            Func<short, int> combin = addOne.Compose(multiplyByTwo);
            Func<int, short> reverse = multiplyByTwo.Compose(addOne);

            Console.WriteLine($"addOne.Compose(multiplyByTwo)(3) = {combin(3)}");
            Console.WriteLine($"multiplyByTwo.Compose(addOne)(3) = {combin(3)}");

            int result = 3
              .Pipe(addOne)
              .Pipe(multiplyByTwo);

            Console.WriteLine($"3.Pipe(addOne).Pipe(multiplyByTwo) = {result}");
        }
    }
}
