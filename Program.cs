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

            Console.WriteLine("EasyQueue");
            var easyQueue = new EasyQueue<int>();

            easyQueue.Enqueue(1); // Добавление данных
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            easyQueue.Enqueue(4);
            easyQueue.Enqueue(5);

            Console.WriteLine(easyQueue.Dequeue());// Извлекаем первый елемент
            Console.WriteLine(easyQueue.Peek()); // Смотрим на Head
            Console.WriteLine(easyQueue.Dequeue()); // Извлекаем первый елемент снова
            Console.WriteLine();
            //--------------------------------------------------------------------

            // ArrayQueue

            Console.WriteLine("ArrayQueue");

            var arrayQueue = new ArrayQueue<int>(10);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(2);
            arrayQueue.Enqueue(3);
            arrayQueue.Enqueue(4);
            arrayQueue.Enqueue(5);

            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());

            Console.WriteLine();
            //----------------------------------------------------------------------

            // LinkedQueue

            Console.WriteLine("LinkedQueue");

            var linkedQueue = new LinkedQueue<int>();
            linkedQueue.Enqueue(1);
            linkedQueue.Enqueue(2);
            linkedQueue.Enqueue(3);
            linkedQueue.Enqueue(4);
            linkedQueue.Enqueue(5);

            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Peek());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Dequeue());

            Console.WriteLine();
            //----------------------------------------------------------------------

            Console.WriteLine("EasyDeque");

            var easyDeque = new EasyDeque<int>();
            easyDeque.PushFront(1);
            easyDeque.PushFront(2);
            easyDeque.PushFront(3);
            easyDeque.PushBack(40);
            easyDeque.PushBack(50);
            easyDeque.PushFront(600);
            easyDeque.PushBack(700);

            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopBack());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopBack());


            Console.WriteLine();
            //----------------------------------------------------------------------






            Console.ReadLine();
        }
    }
}
