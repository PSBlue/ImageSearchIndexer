using System;
using Microsoft.Azure.Documents;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    log.Verbose($"C# Timer trigger function executed (test) at: {DateTime.Now}");    
}