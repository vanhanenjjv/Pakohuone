using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pakohuone.Entities
{
    public class World
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Range(0, 240, ErrorMessage = "Time (in minutes) must be between 0 and 240.")]
        [Required]
        public int Time { get; set; }

        [Required]
        public string Directory { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
