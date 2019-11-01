using System.Collections.Generic;

using StandardUtils.Models.DataTransferObjects;
using StandardUtils.Models.Responses;

namespace StandardUtils.Models.Requests
{
    public abstract class BaseRevisionResponse<T> : BaseResponse where T : BaseDto, new()
    {
        public List<RevisionDto<T>> Items { get; set; }

        protected BaseRevisionResponse()
        {
            Items = new List<RevisionDto<T>>();
        }
    }
}