using System;
using Xunit;
using Double_ended_queue.DoubleEndedQueue;
using FluentAssertions;

namespace Double_ended_queue_Unit_Tests
{
    public class DequeueUnitTests
    {
        public DequeueUnitTests()
        {

        }

        [Fact]
        public void PushFront_SingleItem_PopFrontSuccessful()
        {
            var dequeue = new DeQueue<string>();
            var firstElement = "first element";
            dequeue.PushFront(firstElement);

            dequeue.PopFront().Should().Be(firstElement);
        }
        [Fact]
        public void PushBack_SingleItem_PopBackSuccessful()
        {
            var dequeue = new DeQueue<string>();
            var firstElement = "first element";
            dequeue.PushBack(firstElement);

            dequeue.PopBack().Should().Be(firstElement);
        }
        [Fact]
        public void PushFront_SingleItem_PopBackSuccessful()
        {
            var dequeue = new DeQueue<string>();
            var firstElement = "first element";
            dequeue.PushFront(firstElement);

            dequeue.PopBack().Should().Be(firstElement);
        }
        [Fact]
        public void PushBack_SingleItem_PopFrontSuccessful()
        {
            var dequeue = new DeQueue<string>();
            var firstElement = "first element";
            dequeue.PushBack(firstElement);

            dequeue.PopFront().Should().Be(firstElement);
        }
        [Fact]
        public void PushFront_MultipleItems_PopFrontSuccessful()
        {
            var dequeue = new DeQueue<string>();
            var firstElement = "first element";
            dequeue.PushFront(firstElement);
            var secondElement = "second element";
            dequeue.PushFront(secondElement);
            var thridElement = "thrid element";
            dequeue.PushFront(thridElement);

            dequeue.PopFront().Should().Be(thridElement);
            dequeue.PopFront().Should().Be(secondElement);
            dequeue.PopFront().Should().Be(firstElement);
        }
        [Fact]
        public void PushFront_MultipleItems_PopBackSuccessful()
        {
            var dequeue = new DeQueue<string>();
            var firstElement = "first element";
            dequeue.PushFront(firstElement);
            var secondElement = "second element";
            dequeue.PushFront(secondElement);
            var thridElement = "thrid element";
            dequeue.PushFront(thridElement);

            dequeue.PopBack().Should().Be(firstElement);
            dequeue.PopBack().Should().Be(secondElement);
            dequeue.PopBack().Should().Be(thridElement);
        }
        [Fact]
        public void PushFront_MultipleItems_CombinedPopSuccessful()
        {
            var dequeue = new DeQueue<string>();
            var firstElement = "first element";
            dequeue.PushFront(firstElement);
            var secondElement = "second element";
            dequeue.PushFront(secondElement);
            var thridElement = "thrid element";
            dequeue.PushFront(thridElement);

            dequeue.PopBack().Should().Be(firstElement);
            dequeue.PopFront().Should().Be(thridElement);
            dequeue.PopBack().Should().Be(secondElement);

        }
        [Fact]
        public void PushFront_MultipleItems_PeekDoesNotRSemoveItem()
        {
            var dequeue = new DeQueue<string>();
            var firstElement = "first element";
            dequeue.PushFront(firstElement);
            var secondElement = "second element";
            dequeue.PushFront(secondElement);
            var thridElement = "thrid element";
            dequeue.PushFront(thridElement);

            dequeue.PeekBack().Should().Be(firstElement);
            dequeue.PopBack().Should().Be(firstElement);
            dequeue.PeekFront().Should().Be(thridElement);
            dequeue.PopFront().Should().Be(thridElement);
            dequeue.PeekBack().Should().Be(secondElement);
            dequeue.PopBack().Should().Be(secondElement);

        }
        [Fact]
        public void PopFront_NoElementsAdded_InvalidOperationException()
        {
            var dequeue = new DeQueue<string>();

            Assert.Throws<InvalidOperationException>(() => dequeue.PopFront());
        }
        [Fact]
        public void PopFront_PopTooManyTimes_InvalidOperationException()
        {
            var dequeue = new DeQueue<string>();
            var firstElement = "first element";
            dequeue.PushFront(firstElement);

            dequeue.PopFront();
            Assert.Throws<InvalidOperationException>(() => dequeue.PopFront());
        }

        [Fact]
        public void PopBack_NoElementsAdded_InvalidOperationException()
        {
            var dequeue = new DeQueue<string>();

            Assert.Throws<InvalidOperationException>(() => dequeue.PopBack());
        }
        [Fact]
        public void PopBack_PopTooManyTimes_InvalidOperationException()
        {
            var dequeue = new DeQueue<string>();
            var firstElement = "first element";
            dequeue.PushFront(firstElement);

            dequeue.PopBack();
            Assert.Throws<InvalidOperationException>(() => dequeue.PopBack());
        }


        [Fact]
        public void PeekBack_NoElementsAdded_InvalidOperationException()
        {
            var dequeue = new DeQueue<string>();

            Assert.Throws<InvalidOperationException>(() => dequeue.PeekBack());
        }
        [Fact]
        public void PeekBack_PopTooManyTimes_InvalidOperationException()
        {
            var dequeue = new DeQueue<string>();
            var firstElement = "first element";
            dequeue.PushFront(firstElement);

            dequeue.PopBack();
            Assert.Throws<InvalidOperationException>(() => dequeue.PeekBack());
        }

        [Fact]
        public void PeekFront_NoElementsAdded_InvalidOperationException()
        {
            var dequeue = new DeQueue<string>();

            Assert.Throws<InvalidOperationException>(() => dequeue.PeekFront());
        }
        [Fact]
        public void PeekFront_PopTooManyTimes_InvalidOperationException()
        {
            var dequeue = new DeQueue<string>();
            var firstElement = "first element";
            dequeue.PushFront(firstElement);

            dequeue.PopBack();
            Assert.Throws<InvalidOperationException>(() => dequeue.PeekFront());
        }

        [Fact]
        public void IsEmpty_ItemsExist_ReturnsFalse()
        {
            var dequeue = new DeQueue<string>();
            var firstElement = "first element";
            dequeue.PushFront(firstElement);

            dequeue.IsEmpty().Should().Be(false);
        }
        [Fact]
        public void IsEmpty_NoItemsPushed_ReturnsTrue()
        {
            var dequeue = new DeQueue<string>();
           
            dequeue.IsEmpty().Should().Be(true);
        }
        [Fact]
        public void IsEmpty_AllItemsPoped_ReturnsTrue()
        {
            var dequeue = new DeQueue<string>();
            var firstElement = "first element";
            dequeue.PushFront(firstElement);

            var secondElement = "secondElement element";
            dequeue.PushFront(secondElement);

            dequeue.PopFront();
            dequeue.PopBack();
            dequeue.IsEmpty().Should().Be(true);
        }
    }
}
