using System;
using System.ComponentModel.DataAnnotations;

namespace OutBrain.Models
{
    public class DocumentsMeta
    {
        [Key]
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public int SourceId { get; set; }
        public int PublisherId { get; set; }
        public DateTime PublishTime { get; set; }
    }
}