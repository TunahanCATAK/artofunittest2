using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogAn.Classes;
using LogAn.Interfaces;

namespace LogAn
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;
        private IWebService service;

        public LogAnalyzer(IExtensionManager mgr)
        {
            manager = mgr;
        }

        public LogAnalyzer(IWebService srv)
        {
            service = srv;
        }

        public bool IsValidLogFilename(string fileName)
        {
            return manager.IsValid(fileName);
        }

        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                service.LogError("Filename too short:" + fileName);
            }
        }
    }
}
