﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MySportsClub.Models
{
    [Table("Enrollment")]
    public class Enrollment
    {
        public int ID { get; set; }
        public int MemberID { get; set; }
        public int WorkoutID { get; set; }

        public Member Member { get; set; }
        public Workout Workout { get; set; }
    }
}
