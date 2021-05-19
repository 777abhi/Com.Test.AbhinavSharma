using System;

namespace Com.Test.AbhinavSharma.Helpers
{
    class GenericHelper
    {
        public static void OutputFormattedAs(string format
            , string title
            , string content
            )
        {
            if (format.Equals(""))
            {
                Console.WriteLine("_____________________________________________________________");
                Console.WriteLine(title + " : ");
                Console.WriteLine(content);
                Console.WriteLine("=============================================================");
            }
        }
    }
}