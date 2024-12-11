using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generikus
{
    using System;
    using System.Collections.Generic;

    public class PriorityQueue<T>
    {
        private List<(T Item, int Priority)> elements;

        public PriorityQueue()
        {
            elements = new List<(T, int)>();
        }

        public void Enqueue(T item, int priority)
        {
            elements.Add((item, priority));
            elements.Sort((x, y) => x.Priority.CompareTo(y.Priority));
        }

        public T Dequeue()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("The priority queue is empty.");
            }

            var highestPriorityItem = elements[0].Item;
            elements.RemoveAt(0);
            return highestPriorityItem;
        }

        public T Peek()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("The priority queue is empty.");
            }

            return elements[0].Item;
        }

        public bool IsEmpty()
        {
            return elements.Count == 0;
        }
    }
}
