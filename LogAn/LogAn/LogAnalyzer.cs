using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn
{
    public class LogAnalyzer
    {
        public bool IsValidLogFilename(string fileName)
        {
            if (!fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
                return false;
            else return true;
        }
    }
}
