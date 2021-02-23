using Queue__Deck.First_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue__Deque
{
    class Program
    {
        static void Main(string[] args)
        {
            // EasyQueue

            var easyQueue = new EasyQueue<int>();

            easyQueue.Enqueue(1);
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            easyQueue.Enqueue(4);
            easyQueue.Enqueue(5);

            Console.WriteLine(easyQueue.Dequeue());// Извлекаем первый елемент
            Console.WriteLine(easyQueue.Peek()); // Смотрим на Head
            Console.WriteLine(easyQueue.Dequeue()); // Извлекаем первый елемент снова

            Console.ReadLine();
        }
    }
}
