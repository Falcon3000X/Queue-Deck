using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue__Deck.First_Model
{
    /// <summary>
    /// Простая реализация очереди с использованием примитивных примеров и методов на основе List<T>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EasyQueue<T>
    {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();
        public int Count => items.Count;


        public EasyQueue() { }

        public EasyQueue(T data)
        {
            items.Add(data);
        }

        /// <summary>
        /// Добавляет данные на первуб позицию в очереди
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(T data)
        {
            items.Insert(0, data);
        }

        /// <summary>
        /// Удаляет Head из очереди
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            var item = Head;
            items.Remove(item);
            return item;
        }

        /// <summary>
        /// Возвращает первый елемент в очереди
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            return Head;
        }










    }
}
