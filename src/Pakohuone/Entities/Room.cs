using System.ComponentModel.DataAnnotations;

namespace Pakohuone.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public World World { get; set; }

        public Level Level { get; set; }
    }
}
