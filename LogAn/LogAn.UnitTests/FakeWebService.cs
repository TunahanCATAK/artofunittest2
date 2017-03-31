using LogAn.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.UnitTests
{
    public class FakeWebService : IWebService
    {
        public string lastError;

        public void LogError(string message)
        {
            lastError = message;
        }
    }
}
