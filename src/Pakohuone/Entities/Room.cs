using System.ComponentModel.DataAnnotations;

namespace Pakohuone.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required]
        public World World { get; set; }

        public Level Level { get; set; }
    }
}
