namespace practiceExcercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine($"Pop : {stack.Pop()}");
            Console.WriteLine($"Pop : {stack.Pop()}");
            Console.WriteLine($"Pop : {stack.Pop()}");

            stack.Clear();
        }
    }
}
