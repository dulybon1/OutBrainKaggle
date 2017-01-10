using OutBrain.DataAccess;

namespace OutBrain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Data.FillDocumentsCategoryTable();
            Data.FillDocumentsEntityTable();
            Data.FillDocumentsMetaTable();
            Data.FillDocumentsTopicTable();
            Data.FillEventsTable();
            Data.FillClicksTable();
            Data.FillPageViewsTable();
        }
    }
}
