using System;

namespace OutBrain.Models
{
    public class DocumentsMetaCSVReceiver
    {
        public int DocumentId { get; set; }
        public int SourceId { get; set; }
        public int PublisherId { get; set; }
        public DateTime PublishTime { get; set; }
    }
}