using System;

namespace StandardUtils.Models.DataTransferObjects
{
    public abstract class RevisionDto<T> where T : BaseDto
    {
        public int Revision { get; set; }
        public Guid RevisionedByUid { get; set; }
        public string RevisionedByName { get; set; }
        public DateTime RevisionedAt { get; set; }

        public T Item { get; set; }
    }
}