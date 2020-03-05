using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFClient.ServiceReference1;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new CalculatorClient();
            var test = client.Add(1, 2);
            Console.WriteLine(test);
            }
    }
}
