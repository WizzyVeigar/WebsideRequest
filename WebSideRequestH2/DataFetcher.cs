using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebSideRequestH2
{
    public abstract class DataFetcher : IDataFetcher
    {
        public DataFetcher(string path)
        {
            Path = path;
        }
        private string path;
        public string Path
        {
            get
            {
                return path;
            }
            protected set
            {
                path = value;
            }
        }
        public abstract string FetchData();
    }
}
