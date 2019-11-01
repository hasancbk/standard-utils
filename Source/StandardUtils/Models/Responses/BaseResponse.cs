using System.Collections.Generic;

using StandardUtils.Enumerations;
using StandardUtils.Models.DataTransferObjects;
using StandardUtils.Models.Shared;

namespace StandardUtils.Models.Responses
{
    public abstract class BaseResponse
    {
        public ResponseStatus Status { get; set; }
        public List<string> ErrorMessages { get; set; }

        protected BaseResponse()
        {
            Status = ResponseStatus.Unknown;
            ErrorMessages = new List<string>();
        }
        
        public void SetInvalid()
        {
            Status = ResponseStatus.Invalid;
            ErrorMessages.Add(ResponseStatus.Invalid.Description);
        }

        public void SetInvalidBecauseMustBeUnique(string entityName = "entity")
        {
            Status = ResponseStatus.Invalid;
            ErrorMessages.Add(entityName.ToLowerInvariant() + "_must_be_unique");
        }
        
        public void SetInvalidBecauseNotActive(string entityName = "entity")
        {
            Status = ResponseStatus.Invalid;
            ErrorMessages.Add(entityName.ToLowerInvariant() + "_not_active");
        }

        public void SetInvalidBecauseHasChildren(string entityName = "entity")
        {
            Status = ResponseStatus.Invalid;
            ErrorMessages.Add(entityName.ToLowerInvariant() + "_has_children");
        }

        public void SetFailed()
        {
            Status = ResponseStatus.Failed;
            ErrorMessages.Add(ResponseStatus.Failed.Description);
        }

        public void SetFailedBecauseNotFound(string entityName = "entity")
        {
            Status = ResponseStatus.Failed;
            ErrorMessages.Add(entityName.ToLowerInvariant() + "_not_found");
        }
    }
    
    public abstract class BaseResponse<T> : BaseResponse where T : BaseDto, new()
    {
        public T Item { get; set; }
        public List<T> Items { get; set; }

        public PagingInfo PagingInfo { get; set; }

        protected BaseResponse()
        {
            Item = new T();
            Items = new List<T>();

            PagingInfo = new PagingInfo();
        }
    }
}