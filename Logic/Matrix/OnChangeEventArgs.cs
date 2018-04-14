using System;

namespace Logic.Matrix
{
    public class OnChangeEventArgs : EventArgs
    {
        public int I { get; set; }
        public int J { get; set; }
        public object OldValue { get; set; }
        public object NewValue { get; set; }
        public OnChangeEventArgs(int i, int j, object oldValue, object newValue)
        {
            I = i;
            J = j;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}