using System.ComponentModel.DataAnnotations;

namespace OutBrain.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public int DisplayId { get; set; }
        public int Uuid { get; set; }
        public int DocumentId { get; set; }
        public int TimeStamp { get; set; }
        public int Platform { get; set; }
        public string GeoLocation { get; set; }
    }
}