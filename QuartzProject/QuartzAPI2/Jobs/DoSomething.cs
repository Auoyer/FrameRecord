using Quartz;
using System;
using System.IO;

namespace QuartzAPI2.Jobs
{
    [DisallowConcurrentExecution]
    public class DoSomething : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            File.WriteAllText(@"E:\QuartzAPI2.txt", "2.0");
        }
    }
}
