using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace SimpleWCFService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class SimpleService : ISimpleService
    {
        public string DoWork()
        {
            Thread.Sleep(1000);
            var response = $"Thread {Thread.CurrentThread.ManagedThreadId} started processing at {DateTime.Now}";
            Console.WriteLine(response);
            return response;
        }
    }
}
