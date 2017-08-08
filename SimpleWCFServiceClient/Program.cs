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
           
            for (int i = 1; i <= 500; i++)
            {
                var client = new ServiceReference1.SimpleServiceClient();
                var thread = new Thread(client.DoWork);
                thread.Start();
               
            }
        }
    }
}
