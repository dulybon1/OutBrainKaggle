using System.ComponentModel.DataAnnotations;

namespace OutBrain.Models
{
    public class DocumentsEntity
    {
        [Key]
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public int EntityId { get; set; }
        public double ConfidenceLevel { get; set; }
    }
}