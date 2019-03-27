using HZQ.Job.Model;
using HZQ.Job.Service.Api.Filter;
using HZQ.Job.Service.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace HZQ.Job.Service.Api.Controller
{
    /// <summary>
    /// job控制器
    /// </summary>
    [SchedulerFilter]
    public class JobController : ApiController
    {
        /// <summary>
        /// 启动
        /// </summary>
        /// <param name="jobInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public JobResult Run(JobInfo jobInfo)
        {
            return Execute(() => SchedulerManager.Singleton.CreateJob(jobInfo));
        }

        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="jobInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public JobResult Pause(JobInfo jobInfo)
        {
            return Execute(() => SchedulerManager.Singleton.Pause(jobInfo));
        }

        /// <summary>
        /// 恢复
        /// </summary>
        /// <param name="jobInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public JobResult Resume(JobInfo jobInfo)
        {
            return Execute(() => SchedulerManager.Singleton.Resume(jobInfo));
        }

        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="jobInfo"></param>
        /// <returns></returns>
        [HttpPost]

        public JobResult Remove(JobInfo jobInfo)
        {
            return Execute(() => SchedulerManager.Singleton.Remove(jobInfo));
        }


        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="jobInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public JobResult Update(JobInfo jobInfo)
        {
            return Execute(() => SchedulerManager.Singleton.Update(jobInfo));
        }

        /// <summary>
        /// 更换版本
        /// </summary>
        /// <param name="jobInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public JobResult Upgrade(JobInfo jobInfo)
        {
            return Execute(() => SchedulerManager.Singleton.Upgrade(jobInfo));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="func"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        private JobResult Execute(Func<bool> func, [CallerMemberName] string method = null)
        {
            var result = new JobResult { Code = 200 };
            try
            {
                result.Code = func.Invoke() ? 200 : 400;
            }
            catch (Exception ex)
            {
                result.Msg = ex.Message;
            }
            return result;
        }
    }
}
