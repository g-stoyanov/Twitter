namespace TwitterSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TwitterSystem.Data.Common.Models;

    public class TwitterProfile : AuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        [Index]
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int ApplicationUserId { get; set; }

        //public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Tweet> Tweeets { get; set; }

        public virtual ICollection<TwitterProfile> FollowingProfiles { get; set; }

        public virtual ICollection<TwitterProfile> Followers { get; set; }

        public virtual ICollection<Tweet> FavouriteTweeets { get; set; }
    }
}
