using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySportsClub.Models
{
    [Table("Member")]
    public class Member
    {
        public int ID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        // todo lesson 6 - add property Email
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartMembership { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
