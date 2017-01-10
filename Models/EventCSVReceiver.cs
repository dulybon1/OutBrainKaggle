namespace OutBrain.Models
{
    public class EventCSVReceiver
    {
        
        public int DisplayId { get; set; }
        public int Uuid { get; set; }
        public int DocumentId { get; set; }
        public int TimeStamp { get; set; }
        public int Platform { get; set; }
        public string GeoLocation { get; set; }
    }
}