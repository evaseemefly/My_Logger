using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class LoggerFactory
    {
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

        private ILogger ilogger;

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
    }
}
