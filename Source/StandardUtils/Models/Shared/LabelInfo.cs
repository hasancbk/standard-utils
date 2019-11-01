using System;
using System.Collections.Generic;

namespace StandardUtils.Models.Shared
{
    public class LabelInfo
    {
        public Guid uid { get; set; }
        public string key { get; set; }
        public List<TranslationInfo> translations { get; set; }

        public LabelInfo()
        {
            translations = new List<TranslationInfo>();
        }
    }
}