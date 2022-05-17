using System;

namespace _18_OOP_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            // OOP'nin en önemli noktası
            // I harfi ile başlarlar
            /*FileLogger FL = new FileLogger();
            FL.WriteLog();

            DatabaseLogger DL = new DatabaseLogger();
            DL.WriteLog();

            SmsLogger SL = new SmsLogger();
            SL.WriteLog();*/

            LogManager LM = new LogManager(new FileLogger());
            LM.WriteLog();
        }
    }
}
