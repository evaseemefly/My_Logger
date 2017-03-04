using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Config
{
    public class Logger
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute]
        public string Type { get; set; }

        [XmlElementAttribute]
        public string Level { get; set; }

        [XmlElementAttribute]
        public string ProjectName { get; set; }
    }
}
