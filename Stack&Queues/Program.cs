// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace QueueUsingLinkedList
{
    public class Program
    {
        
       
        public static void Main(string[] args)
        {
            
            LinkedListQueue List = new LinkedListQueue();
            List.Enqueue(56);
            List.Enqueue(30);
            List.Enqueue(70);
            
            //Removing Elements From Queue
            //Console.WriteLine(que.Dequeue);
          
            List.Display();

           
           
        }
    }
}
