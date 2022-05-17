using System;

namespace _18_OOP_Interface
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Doyaya log yazar.");
        }
    }
}