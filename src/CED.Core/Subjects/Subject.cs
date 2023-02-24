using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;

namespace CED.Subjects
{
    public class Subject : Entity<Guid>, IHasCreationTime, IHasDeletionTime
    {
        public string Name { get; set; }
        public DateTime? DeletionTime { get ; set; }
        public bool IsDeleted { get; set ; }
        public DateTime CreationTime { get; set; }

        public Subject()
        {
            CreationTime = Clock.Now;
            Name = "";
        }
        public Subject(string name)
            : this()
        {
            Name = name;
        }
    }
}
