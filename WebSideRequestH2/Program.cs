using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebSideRequestH2
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            IDataFetcher dataFetcher = new UrlFetcher(@"https://docs.microsoft.com");
            IDataFetcher fetcher = new FileFetcher(@"LocalPath");

            logger.LogMessage(dataFetcher.FetchData());
            logger.LogMessage(fetcher.FetchData());
            
            Console.Read();
        }
    }
}
