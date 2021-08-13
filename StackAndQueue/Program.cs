using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Welcome Message
            Console.WriteLine("Welcome to Stack and Queue !");
            Console.WriteLine("----------------------------");

            //Calling Class and Adding Data in Stack
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);

            //Display Message
            linkedListStack.Display();
        }
    }
}
