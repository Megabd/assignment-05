using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Assignment5.Core;

namespace Assignment5.Entities
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int? AssignedToId { get; set; }

        public User AssignedTo { get; set; }

        public State State { get; set; }

        public string Description { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}