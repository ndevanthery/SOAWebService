using System;

namespace App_console
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceReference1.MS_SQLClient client = new ServiceReference1.MS_SQLClient();

            float result = client.AddAmount("10000", (float)(10000));
            Console.WriteLine("this is the result");
            Console.WriteLine(result);
        }
    }
}
