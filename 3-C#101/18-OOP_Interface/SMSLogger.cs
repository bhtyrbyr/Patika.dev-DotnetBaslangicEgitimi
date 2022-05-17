using System;

namespace _18_OOP_Interface
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Sms olarak log yazar.");
        }
    }
}