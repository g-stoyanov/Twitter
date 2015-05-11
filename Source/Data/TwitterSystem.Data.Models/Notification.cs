namespace TwitterSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TwitterSystem.Data.Common.Models;


    public class Notification : AuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime PublishedOn { get; set; }

        public string Link { get; set; }

        public bool IsReaded { get; set; }

        public string Content { get; set; }

        public int ProfileId { get; set; }

        public virtual TwitterProfile AuthorId { get; set; }

        [Index]
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
