using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonZad1
{
    public class RomanEmplyee

    {
        DateTime workingStart;
        DateTime workingStop;
        TimeSpan durtion;
        public static void  WorkingTime()
        {
            if (roman == null)
            {
                TimeSpan duration = Start().workingStart - Stop().workingStop;
            }
            

        }
        public static bool IsWorking()
        {
            if (roman == null)
                return false;
            else
            {
                return true;
            }
        }
        private static RomanEmplyee roman = null;
        public static RomanEmplyee Start()
        {
            {
                if (roman == null)
                {
                    roman = new RomanEmplyee();
                    DateTime workingStart = DateTime.Now;
                }
                    return roman;
            }
        }
        public static RomanEmplyee Stop()
        {
            if (roman != null)
            {
                roman = null;
                DateTime workingStop = DateTime.Now;
            }
            return roman = null;
        }



    }// class end
}
