using System;

namespace Authentication.Api.Base
{
    public abstract class BaseEntity 
    {
        protected BaseEntity()
        {
        }

        public Guid Id { get; set; }
        public DateTime DateCreted { get; set; }
        public DateTime DateDeleted { get; set; }
        public DateTime DateLastUpdated { get; set; }

    }
}
