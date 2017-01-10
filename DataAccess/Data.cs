using System.IO;
using CsvHelper;
using OutBrain.Models;

namespace OutBrain.DataAccess
{
    public class Data
    {
        private readonly static DatabaseContext _db = new DatabaseContext();

        public static void FillDocumentsCategoryTable()
        {
            string filename = "CsvData/documents_categories.csv";

            //open and read filename
            var reader = File.OpenText(filename);

            //read csv
            var csv = new CsvReader(reader);
            var records = csv.GetRecords<DocumentsCategoryCSVReceiver>();

            foreach(var record in records)
            {
                var dc = new DocumentsCategory();

                dc.DocumentId = record.DocumentId;
                dc.CategoryId = record.CategoryId;
                dc.ConfidenceLevel = record.ConfidenceLevel;

                _db.DocumentsCategories.Add(dc);
                _db.SaveChanges();
                
            }
        }

        public static void FillDocumentsEntityTable()
        {
            string filename = "CsvData/documents_entities.csv";

            //open and read filename
            var reader = File.OpenText(filename);

            //read csv
            var csv = new CsvReader(reader);
            var records = csv.GetRecords<DocumentsEntityCSVReceiver>();

            foreach(var record in records)
            {
                var dc = new DocumentsEntity();

                dc.DocumentId = record.DocumentId;
                dc.EntityId = record.EntityId;
                dc.ConfidenceLevel = record.ConfidenceLevel;

                _db.DocumentsEntities.Add(dc);
                _db.SaveChanges();
                
            }
        }

        public static void FillDocumentsMetaTable()
        {
            string filename = "CsvData/documents_meta.csv";

            //open and read filename
            var reader = File.OpenText(filename);

            //read csv
            var csv = new CsvReader(reader);
            var records = csv.GetRecords<DocumentsMetaCSVReceiver>();

            foreach(var record in records)
            {
                var dc = new DocumentsMeta();

                dc.DocumentId = record.DocumentId;
                dc.SourceId = record.SourceId;
                dc.PublisherId = record.PublisherId;
                dc.PublishTime = record.PublishTime;

                _db.DocumentsMetas.Add(dc);
                _db.SaveChanges();
                
            }
        }
        public static void FillDocumentsTopicTable()
        {
            string filename = "CsvData/documents_topics.csv";

            //open and read filename
            var reader = File.OpenText(filename);

            //read csv
            var csv = new CsvReader(reader);
            var records = csv.GetRecords<DocumentsTopicCSVReceiver>();

            foreach(var record in records)
            {
                var dc = new DocumentsTopic();

                dc.DocumentId = record.DocumentId;
                dc.TopicId = record.TopicId;
                dc.ConfidenceLevel = record.ConfidenceLevel;
                
                _db.DocumentsTopics.Add(dc);
                _db.SaveChanges();
                
            }
        }

        public static void FillEventsTable()
        {
            string filename = "CsvData/events.csv";

            //open and read filename
            var reader = File.OpenText(filename);

            //read csv
            var csv = new CsvReader(reader);
            var records = csv.GetRecords<EventCSVReceiver>();

            foreach(var record in records)
            {
                var dc = new Event();

                dc.DisplayId = record.DisplayId;
                dc.Uuid = record.Uuid;
                dc.DocumentId = record.DocumentId;
                dc.TimeStamp = record.TimeStamp;
                dc.GeoLocation = record.GeoLocation;
                
                _db.Events.Add(dc);
                _db.SaveChanges();
                
            }
        } 

        public static void FillClicksTable()
        {
            string filename = "CsvData/clicks_test.csv";

            //open and read filename
            var reader = File.OpenText(filename);

            //read csv
            var csv = new CsvReader(reader);
            var records = csv.GetRecords<ClickCSVReceiver>();

            foreach(var record in records)
            {
                var dc = new Click();

                dc.DisplayId = record.DisplayId;
                dc.AdId = record.AdId;
                
                
                _db.Clicks.Add(dc);
                _db.SaveChanges();
                
            }
        }

        public static void FillPageViewsTable()
        {
            string filename = "CsvData/page_views_sample.csv";

            //open and read filename
            var reader = File.OpenText(filename);

            //read csv
            var csv = new CsvReader(reader);
            var records = csv.GetRecords<PageViewCSVReceiver>();

            foreach(var record in records)
            {
                var dc = new PageView();

                dc.UuId = record.UuId;
                dc.DocumentId = record.DocumentId;
                dc.TimeStamp = record.TimeStamp;
                dc.Platform = record.Platform;
                dc.GeoLocation = record.GeoLocation;
                dc.TrafficSource = record.TrafficSource;
                
                _db.PageViews.Add(dc);
                _db.SaveChanges();
                
            }
        }
    }
}