namespace Application.Models.Base
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract class AuditInfo : IAuditInfo
    {
        [Column(TypeName = "DateTime2")]
        public DateTime CreatedOn { get; set; }

        [NotMapped]
        public bool PreserveCreatedOn { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime? ModifiedOn { get; set; }

        [Index]
        [Column(TypeName = "DateTime2")]
        public DateTime? DeletedOn { get; set; }
    }
}
