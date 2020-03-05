using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWcf
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpUri = new Uri("http://localhost/testcalculator");
            var netTcpUri = new Uri("net.tcp://localhost/testcalculator");
            var httpsUri = new Uri("https://localhost/testcalculator");
            ServiceHost selfHost = new ServiceHost(typeof(Calculator), httpUri, netTcpUri,httpsUri);



            // Step 5: Start the service.
            selfHost.Open();
            Console.WriteLine("The service is ready.");


            Console.ReadLine();
            selfHost.Close();
        }
    }
}
