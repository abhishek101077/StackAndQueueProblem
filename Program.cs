namespace StackAndQueueProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the stack element");
            UC_1CreateStack stacklist = new UC_1CreateStack();
            stacklist.Push(70);
            stacklist.Push(30);
            stacklist.Push(56);
            stacklist.Display();
            Console.ReadLine();
        }
    }
}