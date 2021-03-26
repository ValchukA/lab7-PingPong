using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PingPong
{
    public class Pong
    {
        public event EventHandler PongOccured;

        public void OnPongOccured() => PongOccured?.Invoke(this, EventArgs.Empty);

        public void PingHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Pong received Ping");

            Thread.Sleep(500);

            OnPongOccured();
        }
    }
}
