using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.LogInstance
{
    public class Log4NetLogger : LoggerBase
    {
        /// <summary>
        /// log4net配置文件路径
        /// </summary>
        static string _logConfig = string.Empty;
        /// <summary>
        /// log4net日志执行者
        /// </summary>
        static log4net.Core.LogImpl logImpl;

        protected override void WriteLogger(string msg)
        {
            logImpl.Info(msg);
        }
    }
}
