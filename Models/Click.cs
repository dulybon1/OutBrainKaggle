using System.ComponentModel.DataAnnotations;

namespace OutBrain.Models
{
    public class Click
    {
        [Key]
        public int Id { get; set; }
        public int DisplayId { get; set; }
        public int AdId { get; set; }
        
    }
}