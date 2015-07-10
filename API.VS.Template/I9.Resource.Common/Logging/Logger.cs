using I9.$Resource$.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I9.$resource$.Common
{
    public class Logger :ILogger
    {
        public void WriteCriticalLog(ILog message)
        {
            //write(message.ToString());
            
        }
    }
}
