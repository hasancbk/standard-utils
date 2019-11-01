using System;

namespace StandardUtils.Models.Shared
{
    public abstract class BaseCurrentOrganization
    {
        public long Id { get; set; }
        public Guid Uid { get; set; }
        public string Name { get; set; }
        
        public string DecimalSeparator { get; set; }
        public string DigitGroupingSymbol { get; set; }

        public string LongDateFormat { get; set; }
        public string ShortDateFormat { get; set; }
        public string LongTimeFormat { get; set; }
        public string ShortTimeFormat { get; set; }
    }
}