using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Double_ended_queue.DoubleEndedQueue
{
    public class DeQueue<T>
    {
        private LinkedList<T> innerContainer { get; set; }

        public DeQueue()
        {
            innerContainer = new LinkedList<T>();
        }


        public T PopBack()
        {
            if (!innerContainer.Any())
            {
                throw new InvalidOperationException("no more items to pop");
            }
            T poppedElement;
            lock (innerContainer)
            {
                poppedElement = innerContainer.Last.Value;
                innerContainer.RemoveLast();
            }

            return poppedElement;
        }
        public T PopFront()
        {
            if (!innerContainer.Any())
            {
                throw new InvalidOperationException("no more items to pop");
            }

            T poppedElement;
            lock (innerContainer)
            {
                poppedElement = innerContainer.First.Value;
            }
            innerContainer.RemoveFirst();
            return poppedElement;
        }

        public void PushFront(T newElement)
        {
            lock (innerContainer)
            {
                innerContainer.AddFirst(newElement);
            }
           
        }
        public void PushBack(T newElement)
        {
            lock (innerContainer)
            {
                innerContainer.AddLast(newElement);
            }
        }

        public T PeekFront()
        {
            if (!innerContainer.Any())
            {
                throw new InvalidOperationException("Double ended queue is empty");
            }
            return innerContainer.First.Value;
        }
        public T PeekBack()
        {
            if (!innerContainer.Any())
            {
                throw new InvalidOperationException("Double ended queue is empty");
            }
            return innerContainer.Last.Value;
        }
        public bool IsEmpty()
        {
            return !innerContainer.Any();
        }
    }
}
