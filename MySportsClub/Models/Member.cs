using System.ComponentModel.DataAnnotations;

namespace MySportsClub.Models
{
    public class Member
    {
        public int ID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartMembership { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
