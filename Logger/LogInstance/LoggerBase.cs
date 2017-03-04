using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Logger.LogInstance
{
    public abstract class LoggerBase : ILogger
    {
        /// <summary>
        /// 日志文件地址
        /// 优化级为mvc方案地址，网站方案地址，console程序地址
        /// </summary>
        protected string FileUrl
        {
            get
            {
                try
                {
                    //在当前进程的应用程序域中找到LoggerDir目录
                    return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LoggerDir");
                }
                catch (Exception)
                {

                    try
                    {
                        return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "LoggerDir");
                    }
                    catch (Exception)
                    {
                        return Path.Combine(System.Web.HttpContext.Current.Request.PhysicalApplicationPath, "LoggerDir");
                    }
                }

            }

        }

        protected abstract void WriteLogger(string msg);

        public void Logger_Debug(string message)
        {
            throw new NotImplementedException();
        }

        public void Logger_Error(Exception ex)
        {
            throw new NotImplementedException();
        }

        public void Logger_Exception(string message, Action action)
        {
            throw new NotImplementedException();
        }

        public void Logger_Fatal(string message)
        {
            throw new NotImplementedException();
        }

        public void Logger_Info(string message)
        {
            throw new NotImplementedException();
        }

        public void Logger_Timer(string message, Action action)
        {
            throw new NotImplementedException();
        }

        public void Logger_Warn(string message)
        {
            throw new NotImplementedException();
        }
    }
}
