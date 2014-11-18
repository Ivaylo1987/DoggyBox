namespace Application.Models.Base
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public interface IAuditInfo
    {
        [Column(TypeName = "DateTime2")]
        DateTime CreatedOn { get; set; }

        bool PreserveCreatedOn { get; set; }

        [Column(TypeName = "DateTime2")]
        DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "DateTime2")]
        DateTime? DeletedOn { get; set; }
    }
}
