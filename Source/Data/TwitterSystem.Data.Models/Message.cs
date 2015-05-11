namespace TwitterSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TwitterSystem.Data.Common.Models;

    public class Message : AuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime PublishedOn { get; set; }

        public string Content { get; set; }

        public bool IsReaded { get; set; }

        public int AuthorTwitterProfileId { get; set; }

        public virtual TwitterProfile Author { get; set; }

        public int RecipientTwitterProfileId { get; set; }

        public virtual TwitterProfile Recipient { get; set; }

        [Index]
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
