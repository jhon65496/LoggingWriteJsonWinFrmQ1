using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NLog;

namespace LoggingWriteJsonWinFrmQ1
{
    internal class Logger1
    {
        public void CreateLogger()
        {
            Logger log = LogManager.GetCurrentClassLogger();

            log.Info("info message. Step-1");
            log.Info("info message. Step-2");
        }
    }
}
