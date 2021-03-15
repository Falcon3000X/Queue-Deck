using System;


namespace Queue__Deck.First_Model
{
    public class LinkedQueue<T>
    {
        private Item<T> head;
        private Item<T> tail;
        public int Count { get; private set; }

        public LinkedQueue() { }

        public LinkedQueue(T data)
        {
            var item = new Item<T>(data);
            head = item;
            tail = item;
            Count = 1;
        }

        /// <summary>
        /// Добавляет данные на первуб позицию в очереди
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new Item<T>(data)
            {
                Next = tail
            };

            tail = item;
            Count++;
        }

        /// <summary>
        /// Удаляет Head из очереди
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            var data = head.Data;

            var current = tail.Next;
            var previous = tail;

            while (current != null && current.Next != null)
            {
                previous = current;
                current = current.Next;
            }

            head = previous;
            head.Next = null;
            Count--;
            return data;
        }

        /// <summary>
        /// Возвращает первый елемент в очереди
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            return head.Data;
        }

        public void SetHeadItem(T data)
        {
            var item = new Item<T>(data);
            head = item;
            tail = item;
            Count = 1;
        }

    }
}
