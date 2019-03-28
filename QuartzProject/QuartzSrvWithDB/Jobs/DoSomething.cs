using Quartz;
using System;
using System.IO;
using System.Threading.Tasks;

namespace QuartzSrvWithDB.Jobs
{
    [DisallowConcurrentExecution]
    public class DoSomething : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            File.WriteAllText(@"E:\QuartzSrvWithDB.txt", "3.0");
            return Task.FromResult(true);
        }
    }
}
