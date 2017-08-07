using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace SimpleWCFService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class SimpleService : ISimpleService
    {
        public void DoWork()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started processing at {DateTime.Now}");
        }
    }
}
