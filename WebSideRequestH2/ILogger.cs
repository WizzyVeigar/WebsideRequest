using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSideRequestH2
{
    interface ILogger
    {
        /// <summary>
        /// Generic method for displaying a message
        /// </summary>
        /// <param name="message">Message you want displayed</param>
        void LogMessage(string message);
    }
}
