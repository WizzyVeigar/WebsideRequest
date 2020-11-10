using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSideRequestH2
{
    interface IDataFetcher
    {
        string Path { get; }
        /// <summary>
        /// Generic method for fetching some data, using the path property
        /// </summary>
        /// <returns>Returns a string with the fetched data</returns>
        string FetchData();

    }
}
