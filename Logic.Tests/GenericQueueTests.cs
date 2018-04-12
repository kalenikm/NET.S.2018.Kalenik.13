using System;
using NUnit.Framework;

namespace Logic.Tests
{
    [TestFixture]
    public class GenericQueueTests
    {
        [Test]
        public void GenericQueueTest()
        {
            GenericQueue<int> queue = new GenericQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            Assert.AreEqual(10, queue.Dequeue());
            Assert.AreEqual(11, queue.Dequeue());
            Assert.AreEqual(12, queue.Dequeue());
        }

        [Test]
        public void GenericQueue_NegativeCapacity_ArgumentException()
        {
            Assert.Catch<ArgumentException>(() => new GenericQueue<int>(-10));
        }

        [Test]
        public void GenericQueue_DequeueEmptyQueue_EmptyQueueException()
        {
            Assert.Catch<EmptyQueueException>(() => new GenericQueue<int>().Dequeue());
        }

        [Test]
        public void GenericQueue_GetEnumeratorTest()
        {
            GenericQueue<int> queue = new GenericQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            int[] res = {10, 11, 12};
            int index = 0;
            foreach (var num in queue)
            {
                Assert.AreEqual(res[index], num);
                index++;
            }
        }
    }
}
