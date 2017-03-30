using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        private LogAnalyzer m_analyzer = null;

        [SetUp]
        public void Setup()
        {
            m_analyzer = new LogAnalyzer();
        }

        [Test]
        public void IsValidFileName_BadExtension_ReturnsFalse()
        {
            bool result = m_analyzer.IsValidLogFilename("filewithbadextension.foo");
            Assert.False(result);
        }

        [Test]
        public void IsValidLogFileName_GoodExtensionLowercase_ReturnsTrue()
        {
            bool result = m_analyzer.IsValidLogFilename("filewithgoodextension.slf");
            Assert.True(result);
        }
    }
}
