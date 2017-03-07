using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.LoggerFactory.Instance.Logger_Debug("测试debug级别日志");
        }
    }
}
