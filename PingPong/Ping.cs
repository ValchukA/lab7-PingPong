using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PingPong
{
    public class Ping
    {
        public event EventHandler PingOccured;

        public void OnPingOccured() => PingOccured?.Invoke(this, EventArgs.Empty);

        public void PongHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Ping received Pong.");

            Thread.Sleep(500);

            OnPingOccured();
        }
    }
}
