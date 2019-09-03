using NLog;
using Quartz;
using Quartz.Impl;
using Quartz.Simpl;
using Quartz.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quartz_Core.App_Start
{
    public class JobScheduler
    {
        public static IScheduler scheduler;
        public static Logger Logger = LogManager.GetCurrentClassLogger();
        static JobScheduler()
        {
            try
            {
                XMLSchedulingDataProcessor processor = new XMLSchedulingDataProcessor(new SimpleTypeLoadHelper());
                StdSchedulerFactory factory = new StdSchedulerFactory();
                scheduler = factory.GetScheduler().GetAwaiter().GetResult();
                processor.ProcessFileAndScheduleJobs("~/quartz_jobs.xml", scheduler);
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex, $"任务加载异常。");
            }
        }

        public static void Start()
        {
            if (scheduler != null)
            {
                scheduler.Start();
                Logger.Info($"任务开启。");
            }
        }

        public static void Stop()
        {
            if (scheduler != null)
            {
                scheduler.Shutdown();
                Logger.Info($"任务停止。");
            }
        }
    }
}
