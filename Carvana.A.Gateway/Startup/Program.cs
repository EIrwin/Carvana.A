using System;
using System.Threading;
using Nancy.Hosting.Self;

namespace Carvana.A.Gateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var uri = new Uri("http://localhost:1234");
            var bootstrapper = new Bootstrapper();
            var hostConfig = new HostConfiguration { UrlReservations = new UrlReservations { CreateAutomatically = true } };
            using (NancyHost host = new NancyHost(bootstrapper, hostConfig, uri))
            {
                host.Start();
                Console.Out.Write("Host Started");

                Thread.Sleep(Timeout.Infinite);
            }
        }
    }
}
