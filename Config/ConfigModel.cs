using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public class ConfigModel
    {
        public ConfigModel()
        {
            this.Logger = new Logger();
        }


        /// <summary>
        /// 日志相关
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public Logger Logger { get; set; }
        
    }
}
