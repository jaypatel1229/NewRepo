//Pass Data From one Class To another  using Event Delegate

using System;

namespace EventAndDelegateEx1
{
    public class AddBuiltinEvent
    {
        public event EventHandler<EventArgs> Addnumbers;
        public void Add()
        {
            int x;
            x = 100 + 150;
            Console.WriteLine("\n Event Add " + (x));
            Console.Read();
            OnCompletedEvent();

        }
        private void OnCompletedEvent()
        {
            Addnumbers?.Invoke(this, EventArgs.Empty);
            Console.Read();
        }
    }
}