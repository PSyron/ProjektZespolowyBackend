using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Checkers.Interfaces;
namespace Checkers.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Logger" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Logger.svc or Logger.svc.cs at the Solution Explorer and start debugging.
    public class Logger : ILogger
    {
        public void DoWork()
        {
        }
    }
}
