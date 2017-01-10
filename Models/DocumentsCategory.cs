using System.ComponentModel.DataAnnotations;

namespace OutBrain.Models
{
    public class DocumentsCategory
    {
        [Key]
        public int Id { get;set; }
        public int DocumentId { get; set; }
        public int CategoryId { get; set; }
        public double ConfidenceLevel { get; set; }
    }
}