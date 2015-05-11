namespace TwitterSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TwitterSystem.Data.Common.Models;

    public class Report : AuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime PublishedOn { get; set; }

        public string Content { get; set; }

        public ReportStatus Status { get; set; }

        public int TwitterProfileId { get; set; }

        public virtual TwitterProfile AuthorId { get; set; }

        public int TweetId { get; set; }

        public Tweet Tweet { get; set; }

        [Index]
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
