using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum;


namespace Logger
{
    public class LoggerFactory
    {
        /// <summary>
        /// 私有的构造函数，对外不能创建类的实例
        /// </summary>
        private LoggerFactory()
        {
            string type = "file";
            switch (type)
            {
                case "log4net":
                    ilogger = new LogInstance.Log4NetLogger();
                    break;
                default:
                    break;
            }
        }

        private static object lockObj = new object();

        private static LoggerFactory instance;

        /// <summary>
        /// 日志提供者，只在本例中实例化
        /// </summary>
        private ILogger ilogger;

        /// <summary>
        /// 日志级别——注意此处未完成
        /// </summary>
        private static LogLevel level = (LogLevel)System.Enum.Parse(typeof(LogLevel),);

        /// <summary>
        /// 使用单例模式——日志工厂
        /// 调用私有的LoggerFactory构造函数，实现单例模式
        /// </summary>
        public static LoggerFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new LoggerFactory();
                        }
                    }
                }
                return instance;
            }
        }

        #region ILogger 成员
        /// <summary>
        /// 记录代码段执行时间
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="action">要执行的代码段</param>
        public void Logger_Timer(string message, Action action)
        {
            ilogger.Logger_Timer(message, action);
        }
        /// <summary>
        /// 记录代码段执行时出现的异常信息
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="action">要执行的代码段</param>
        public void Logger_Exception(string message, Action action)
        {
            ilogger.Logger_Exception(message, action);
        }
        /// <summary>
        /// Debug级别的日志
        /// </summary>
        /// <param name="message"></param>
        public void Logger_Debug(string message)
        {
            if (level <= LogLevel.DEBUG)
                ilogger.Logger_Debug(message);
        }
        /// <summary>
        /// Info级别的日志
        /// </summary>
        /// <param name="message"></param>
        public void Logger_Info(string message)
        {
            if (level <= LogLevel.INFO)
                ilogger.Logger_Info(message);
        }
        /// <summary>
        /// Warn级别的日志
        /// </summary>
        /// <param name="message"></param>
        public void Logger_Warn(string message)
        {
            if (level <= LogLevel.WARN)
                ilogger.Logger_Warn(message);
        }
        /// <summary>
        /// Error级别的日志
        /// </summary>
        /// <param name="ex"></param>
        public void Logger_Error(Exception ex)
        {
            if (level <= LogLevel.ERROR)
                ilogger.Logger_Error(ex);
        }
        /// <summary>
        /// Fatal级别的日志
        /// </summary>
        /// <param name="message"></param>
        public void Logger_Fatal(string message)
        {
            if (level <= LogLevel.FATAL)
                ilogger.Logger_Fatal(message);
        }
        #endregion
    }
}
