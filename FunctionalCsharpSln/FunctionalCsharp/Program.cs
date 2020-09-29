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

            Console.WriteLine(combin(3));
            Console.WriteLine(reverse(3));
        }
    }
}
