﻿namespace TwitterSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TwitterSystem.Data.Common.Models;

    public class Tweet : AuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime PublishedOn { get; set; }

        public string Content { get; set; }

        public int ProfileId { get; set; }

        public virtual TwitterProfile AuthorId { get; set; }

        public virtual ICollection<TwitterProfile> ProfileLikes { get; set; }

        public int TweetId { get; set; }

        public Tweet ParrentTweet { get; set; }

        [Index]
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
