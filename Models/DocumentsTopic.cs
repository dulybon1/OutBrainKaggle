using System.ComponentModel.DataAnnotations;

namespace OutBrain.Models
{
    public class DocumentsTopic
    {
        [Key]
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public int TopicId { get; set; }
        public double ConfidenceLevel { get; set; }
    }
}