using System.IO;

namespace HZQ.JobA
{
    public class Job1 : BaseJob.BaseJob
    {
        protected override void Execute()
        {
            File.WriteAllText(@"E:\JobA.txt", "3.0");
        }
    }
}
