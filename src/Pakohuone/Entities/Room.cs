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

        [Display(Name = "World")]
        public int? WorldId { get; set; }

        [Display(Name = "Level")]
        public int? LevelId { get; set; }

        [Required]
        public World World { get; set; }

        public Level Level { get; set; }
    }
}
