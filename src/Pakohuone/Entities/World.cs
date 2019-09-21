using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pakohuone.Entities
{
    public class World
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Time { get; set; }

        public string Directory { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
