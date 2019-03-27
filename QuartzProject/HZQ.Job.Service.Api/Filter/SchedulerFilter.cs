using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using HZQ.Job.Model;
using Newtonsoft.Json;

namespace HZQ.Job.Service.Api.Filter
{
    /// <summary>
    /// 调度器过滤器
    /// </summary>
    public class SchedulerFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            System.Collections.Generic.Dictionary<string, object> request = actionContext.ActionArguments;

            JobInfo jobInfo = request["jobInfo"] as JobInfo;
            if (jobInfo == null)
            {
                actionContext.Response = CreateResponse(HttpStatusCode.BadRequest, new JobResult
                {
                    Code = 400,
                    Msg = "入参异常,jobInfo 为空"
                });
            }
            else if (!ApiConfig.SchedulerName.Equals(jobInfo.SchedName))
            {
                actionContext.Response = CreateResponse(HttpStatusCode.BadRequest, new JobResult
                {
                    Code = 400,
                    Msg = $" {ApiConfig.ApiAddress} 没有监听 {jobInfo.SchedName} 调度器"
                });
            }
            //else if (SchedulerManager._schedulerIsWorking == false)
            //{
            //    actionContext.Response = CreateResponse(HttpStatusCode.Redirect, new Result
            //    {
            //        Code = 300,
            //        Msg = $" 调度器 {jobInfo.SchedName} 尚处于备用状态,请更换api请求地址"
            //    });
            //}

            base.OnActionExecuting(actionContext);
        }


        private HttpResponseMessage CreateResponse(HttpStatusCode code, JobResult result)
        {
            return new HttpResponseMessage(code)
            {
                Content = new StringContent(JsonConvert.SerializeObject(result))
            };
        }
    }
}
