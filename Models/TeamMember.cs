using System.ComponentModel.DataAnnotations;

namespace DatabaseBizLand.Models
{
    public class TeamMember
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Photo { get; set; }
    }
}
