using System;

namespace StandardUtils.Models.Shared
{
    public abstract class BaseCurrentUser
    {
        public BaseCurrentOrganization Organization { get; set; }
        
        public long Id { get; set; }
        public Guid Uid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        
        public string DecimalSeparator { get; set; }
        public string DigitGroupingSymbol { get; set; }

        public string LongDateFormat { get; set; }
        public string ShortDateFormat { get; set; }
        public string LongTimeFormat { get; set; }
        public string ShortTimeFormat { get; set; }
        
        public string LanguageCode { get; set; }
        
        /// <summary>
        /// used at journal action filters
        /// </summary>
        public bool IsActionSucceed { get; set; }
        public bool IsPasswordChangeRequired { get; set; }
    }
}