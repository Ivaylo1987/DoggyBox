using Application.Models.Base;
using System.ComponentModel.DataAnnotations;
namespace DoggyBox.Model
{
    public class Mark : AuditInfo
    {
        public int Id { get; set; }

        [Range(1, 10)]
        public int Value { get; set; }

        public virtual Course Course { get; set; }

        public virtual Dog Dog { get; set; }
    }
}
