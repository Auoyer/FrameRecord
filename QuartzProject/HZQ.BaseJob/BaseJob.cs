using System;

namespace HZQ.BaseJob
{
    public abstract class BaseJob : MarshalByRefObject
    {
        /// <summary>
        /// 运行
        /// </summary>
        /// <returns>true:运行成功;false:运行失败</returns>
        public bool Run()
        {
            bool res = false;
            try
            {
                Execute();
                res = true;
            }
            catch (Exception ex)
            {
            }
            return res;
        }


        /// <summary>
        /// 具体逻辑
        /// </summary>
        protected abstract void Execute();


        /// <summary>
        /// 将对象生存期更改为永久,因为CLR默认5分钟内没有通过代理发出调用,对象会实效,下次垃圾回收会释放它的内存.
        /// </summary>
        /// <returns></returns>
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
