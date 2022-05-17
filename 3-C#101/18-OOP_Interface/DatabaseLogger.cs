using System;

namespace _18_OOP_Interface
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Database'e log yazar.");
        }
    }
}