using System.ServiceProcess;
using Quartz;
using Quartz.Impl;

namespace QuartzService2
{
    public partial class TestService2 : ServiceBase
    {
        private IScheduler scheduler = new StdSchedulerFactory().GetScheduler();

        public TestService2()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: 在此处添加代码以启动服务。
            scheduler.Start();
        }

        protected override void OnStop()
        {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
            scheduler.Clear();
            scheduler.Shutdown();
        }
    }
}
