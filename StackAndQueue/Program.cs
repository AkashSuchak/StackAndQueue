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

            /*//Calling Class and Adding Data in Stack
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            Console.WriteLine("----------------------------");
            
            //Peek Value from Stack
            linkedListStack.Peek();
            Console.WriteLine("----------------------------");
            linkedListStack.Pop();

            //Pop value till Stack will empty
            linkedListStack.IsEmpty();
*/
            //Calling Class and Adding Data in Stack
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            Console.WriteLine("----------------");

            //Display Queue
            linkedListQueue.Display();
        }
    }
}
