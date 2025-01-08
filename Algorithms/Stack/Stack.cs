using System;

namespace NicolashaDolbaeb.Algorithms.Stack
{
    public class Stack
    {
        private Node _top;

        public void Push(int value)
        {
            var newNode = new Node(value);
            newNode.Next = _top;
            _top = newNode;
        }

        public int Pop()
        {
            if (_top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            var value = _top.Value;
            _top = _top.Next;
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
