namespace Queue__Deck.First_Model
{
    public class ArrayQueue<T>
    {

        private T[] items;
        private T Head => items[Count - 1];
        private T Tail => items[0];
        public int Count { get; private set; }

        public ArrayQueue(int size)
        {
            items = new T[size]; // Установка размера массива
        }




    }
}
