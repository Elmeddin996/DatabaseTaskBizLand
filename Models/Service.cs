using System.ComponentModel.DataAnnotations;

namespace DatabaseBizLand.Models
{
    public class Service
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Icon { get; set; }
    }
}
