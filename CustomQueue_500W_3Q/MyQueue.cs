using System;
using System.Collections.Generic;



namespace CustomQueue_500W_3Q
{
    public class MyQueue<T>
    {
        public List<T> _queue;
       
        public MyQueue(List<T> queue)
        {
            _queue = queue;
        }
        public MyQueue()
        {
            _queue = new List<T>();
        }

        public T Dequeue()
        {
            T item = default(T);


            if (_queue.Count == 0)
            {
                throw new IndexOutOfRangeException("Queue is empty");
            }
            else
            {
                item = _queue[_queue.Count - 1];
                _queue.RemoveAt(_queue.Count - 1);
            }

            return (item);
        }

        public void Enqueue(T item)
        {

            _queue.Add(item);

        }


        public int Size()
        {

            return _queue.Count;
        }

        public T PeekQueue()
        {
            if (_queue.Count == 0)
            {
                throw new IndexOutOfRangeException("Queue is empty");
            }
            return _queue[0];


        }
        public void ClearQueue()
        {

            _queue.Clear();

        }
       
    }
}
