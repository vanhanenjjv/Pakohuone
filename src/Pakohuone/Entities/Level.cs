using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pakohuone.Entities
{
    public class Level
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Directory { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
