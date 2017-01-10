using System.ComponentModel.DataAnnotations;

namespace OutBrain.Models
{
    public class PageView
    {
        [Key]
        public int Id { get; set; }
        public int UuId { get; set; }
        public int DocumentId { get; set; }
        public int TimeStamp { get; set; }
        public int Platform { get; set; }
        public string GeoLocation { get; set; }
        public string  TrafficSource { get; set; }
        
    }
}