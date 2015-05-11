namespace TwitterSystem.Data.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using TwitterSystem.Data.Common.Models;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            //This will prevent UserManager.CreatedAsync from causing exception
            this.CreatedOn = DateTime.Now;
        }

        public int TwitterProfileId { get; set; }

        //public virtual TwitterProfile TwitterProfile { get; set; }
        
        [Index]
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public System.DateTime CreatedOn { get; set; }

        /// <summary>
        /// Specifies whether or not the CreatedOn property should be automatically set.
        /// </summary>
        [NotMapped]
        public bool PreserveCreatedOn { get; set; }      

        public System.DateTime? ModifiedOn { get; set; }
    }
}
