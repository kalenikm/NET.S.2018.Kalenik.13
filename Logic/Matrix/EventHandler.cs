using System;

namespace Logic.Matrix
{
    public class EventHandler
    {
        public void OnMatrixChanged(object sender, OnChangeEventArgs args)
        {
            Console.WriteLine("{0} => element on [{1},{2}] was changed from {3} to {4}.", sender, args.I, args.J, args.OldValue, args.NewValue);
        }
    }
}