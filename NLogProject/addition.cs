using System;
using System.Collections.Generic;
using System.Text;

namespace NLogProject
{
    class addition
    {
        private static readonly NLog nLog = new NLog();
        public int Sum(int num1, int num2)
        {
            if(num1==0 || num2==0)
            {
                nLog.LogDebug(" Debug Success. : Sum() ");
                nLog.LogError(" Expecting null values");
                nLog.LogWarn(" First number or Second number should not be equal.");
            }
            int answer = num1 + num2;
            nLog.LogDebug(" Debug success. : Sum() ");
            nLog.LogInfo(" Sum method passed. Result : " + answer);
            Console.WriteLine(" Sum : " + answer);
            return answer;
        }
    }
}
