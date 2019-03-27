using HZQ.Job.Model;
using HZQ.Job.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HZQ.Job.Host
{
    class Program
    {
        public static void Main(string[] args)
        {
            JobServiceBuilder.BuilderTest().Start(new JobInfo
            {
                AssemblyPath = @"E:\gongwei\my\Go.Job\TestJob1\bin\Debug\TestJob1.dll",
                ClassType = "TestJob1.Job1",
                Second = 5,
            });
        }
    }
}
