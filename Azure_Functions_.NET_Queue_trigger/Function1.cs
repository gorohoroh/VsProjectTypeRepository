using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace Azure_Functions_.NET_Queue_trigger
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([QueueTrigger("myqueue-items", Connection = "")]string myQueueItem, TraceWriter log)
        {
            log.Info($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
