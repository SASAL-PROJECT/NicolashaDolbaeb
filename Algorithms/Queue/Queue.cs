using System;

namespace NicolashaDolbaeb.Algorithms.Queue
{
    public class Queue
    {
        private Node _front;
        private Node _rear;

        public void Enqueue(int value)
        {
            var newNode = new Node(value);
            if (_rear == null)
            {
                _front = _rear = newNode;
                return;
            }
            _rear.Next = newNode;
            _rear = newNode;
        }

        public int Dequeue()
        {
            if (_front == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            var value = _front.Value;
            _front = _front.Next;
            if (_front == null)
            {
                _rear = null;
            }
            return value;
        }

        private class Node
        {
            public int Value { get; }
            public Node Next { get; set; }

            public Node(int value)
            {
                Value = value;
            }
        }
    }
}
