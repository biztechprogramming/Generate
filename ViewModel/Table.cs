namespace Generate.ViewModel
{
    public class Table
    {
        public string TableName { get; set; }
        public List<Column> Columns { get; set; }
        public List<ForeignKey> ForeignKeys { get; set; }

        public Table()
        {
            Columns = new List<Column>();
            ForeignKeys = new List<ForeignKey>();
        }
    }
}