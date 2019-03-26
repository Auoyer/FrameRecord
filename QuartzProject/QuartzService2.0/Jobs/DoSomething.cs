using Quartz;
using System;
using System.IO;

namespace QuartzService2.Jobs
{
    [DisallowConcurrentExecution]
    public class DoSomething : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            File.WriteAllText(@"E:\QuartzService2.txt", "2.0");
        }
    }
}
