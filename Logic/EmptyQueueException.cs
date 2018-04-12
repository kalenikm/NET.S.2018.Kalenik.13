using System;

namespace Logic
{
    public class EmptyQueueException : Exception
    {
        public EmptyQueueException() : base("Queue is empty.") { }

        public EmptyQueueException(string message) : base(message) { }

        public EmptyQueueException(string message, Exception innerException) : base(message, innerException) { }
    }
}