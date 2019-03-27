using HZQ.Job.Service.JobService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HZQ.Job.Service
{
    /// <summary>
    /// 调度服务创建者
    /// </summary>
    public static class JobServiceBuilder
    {
        /// <summary>
        /// 创建一个正式的服务
        /// </summary>
        /// <returns></returns>
        public static IJobService BuilderProduce()
        {
            return new ProduceJobService();
        }
    }
}
