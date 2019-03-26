using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuartzAPI2
{
    public class JobScheduler
    {
        public static void Start()
        {
            IScheduler scheduler = new StdSchedulerFactory().GetScheduler();
            scheduler.Start();
        }
    }
}