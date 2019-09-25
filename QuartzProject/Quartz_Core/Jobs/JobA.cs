using Quartz;
using System.Threading.Tasks;

namespace Quartz_Core.Jobs
{
    [DisallowConcurrentExecution]
    public class JobA : IJob
    {
        /// <summary>
        /// 查询并分析订单汇总信息
        /// </summary>
        /// <param name="context"></param>
        public Task Execute(IJobExecutionContext context)
        {
            // Dosomething();
            return Task.FromResult(true);
        }
    }
}
