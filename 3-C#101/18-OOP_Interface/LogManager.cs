using System;

namespace _18_OOP_Interface
{
    public class LogManager : ILogger
    {
        public ILogger _logger;

        public LogManager(ILogger logger){
            this._logger = logger;
        }
        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}