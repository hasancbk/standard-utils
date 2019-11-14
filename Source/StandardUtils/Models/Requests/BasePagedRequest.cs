using StandardUtils.Models.Shared;

namespace StandardUtils.Models.Requests
{
    public abstract class BasePagedRequest : BaseRequest
    {
        /// <summary>
        /// if skip is greater than 0
        /// service does not checks for LastUid,
        /// To use last uid ensure Skip is 0
        /// </summary>
        public PagingInfo PagingInfo { get; }

        protected BasePagedRequest()
        {
            PagingInfo = new PagingInfo();
        }
    }
}