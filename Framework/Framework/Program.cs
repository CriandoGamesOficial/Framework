using System;
using System.Threading;
using System.Globalization;

namespace Framework
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            CultureInfo cultureInfUs = new CultureInfo("en-US");

            CultureInfo cultureInfoCurrent = Thread.CurrentThread.CurrentCulture;

            Console.WriteLine(Framework.Main.LION);
            Console.ReadKey();
         

        }
    }
}
