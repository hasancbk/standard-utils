using NUnit.Framework;
using Shouldly;
using StandardUtils.Helpers;

namespace StandardUtils.Unit.Tests.Helpers
{
    [TestFixture]
    public class ConverterHelperTests
    {
        [TestCase(1000000, 0.94999999999999996d)]
        public void ConverterHelper_ConvertBytesToMegabytes(long _byte, double megabyte)
        {
            _byte.ConvertBytesToMegabytes().ShouldBe(megabyte);
            
        }

    }
}