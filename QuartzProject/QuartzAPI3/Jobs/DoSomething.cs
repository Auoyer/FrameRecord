using Quartz;
using System;
using System.IO;
using System.Threading.Tasks;

namespace QuartzAPI3.Jobs
{
    [DisallowConcurrentExecution]
    public class DoSomething : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            File.WriteAllText(@"E:\QuartzAPI3.txt", "3.0");
            return Task.FromResult(true);
        }
    }
}
