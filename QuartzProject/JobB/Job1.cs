using System.IO;

namespace HZQ.JobB
{
    public class Job1 : BaseJob.BaseJob
    {
        protected override void Execute()
        {
            File.WriteAllText(@"E:\JobB.txt", "3.0");
        }
    }
}
