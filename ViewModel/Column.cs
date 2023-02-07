namespace Generate.ViewModel
{
    public class Column
    {
        public string Name { get; set; }
        public Type DataType { get; set; }
        public string DbDataType { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsForeignKey { get; set; }
        public bool IsNullable { get; set; }
    }
}
