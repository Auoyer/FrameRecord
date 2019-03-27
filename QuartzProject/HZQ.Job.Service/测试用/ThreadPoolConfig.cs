using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HZQ.Job.Service.测试用
{
    /// <summary>
    /// 线程池配置
    /// </summary>
    public class ThreadPoolConfig
    {
        /// <summary>
        /// 线程池类型
        /// </summary>
        public string Type { get; set; } = "Quartz.Simpl.DefaultThreadPool, Quartz";

        /// <summary>
        /// 线程池线程数量
        /// </summary>
        public string ThreadCount { get; set; } = "5";

        /// <summary>
        /// 优先权
        /// </summary>
        public string ThreadPriority { get; set; } = "Normal";


        public static implicit operator NameValueCollection(ThreadPoolConfig config)
        {
            NameValueCollection properties = new NameValueCollection
            {
                ["quartz.threadPool.type"] = config.Type,
                ["quartz.threadPool.threadCount"] = config.ThreadCount,
                ["quartz.threadPool.threadPriority"] = config.ThreadPriority,
            };
            return properties;
        }
    }
}
