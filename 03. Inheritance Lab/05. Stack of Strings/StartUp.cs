using System;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var stackOfStrings = new StackOfStrings();

            stackOfStrings.Push("1");
            stackOfStrings.Push("2");
            stackOfStrings.Push("3");
            Console.WriteLine(stackOfStrings.Pop());
            Console.WriteLine(stackOfStrings.Peek());
            Console.WriteLine(stackOfStrings.IsEmpty());
        }
    }
}
