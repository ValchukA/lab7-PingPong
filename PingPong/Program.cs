using System;
using System.Threading;
using System.Threading.Tasks;

namespace PingPong
{
    class Program
    {
        static void Main()
        {
            Console.Write("Duration in seconds: ");

            int duration = Convert.ToInt32(Console.ReadLine());

            Task.Run(() =>
            {
                Ping ping = new Ping();
                Pong pong = new Pong();

                ping.PingOccured += pong.PingHandler;
                pong.PongOccured += ping.PongHandler;

                pong.OnPongOccured();
            });

            Thread.Sleep(duration * 1000);
        }
    }
}
