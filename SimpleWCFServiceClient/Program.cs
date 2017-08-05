using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleWCFServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ServiceReference1.SimpleServiceClient();
            for (int i = 1; i <= 100; i++)
            {
                var thread = new Thread(client.DoWork);
                thread.Start();
            }
        }
    }
}
