using Quartz;
using System;
using System.IO;
using System.Threading.Tasks;

namespace QuartzService3.Jobs
{
    [DisallowConcurrentExecution]
    public class DoSomething : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            File.WriteAllText(@"E:\QuartzService3.txt", "3.0");
            return Task.FromResult(true);
        }
    }
}
