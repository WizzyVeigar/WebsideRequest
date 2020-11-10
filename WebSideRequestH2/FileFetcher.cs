using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSideRequestH2
{
    class FileFetcher : DataFetcher
    {
        public FileFetcher(string path) : base(path)
        {
        }

        public override string FetchData()
        {
            return File.ReadAllText(Path);
        }
    }
}
