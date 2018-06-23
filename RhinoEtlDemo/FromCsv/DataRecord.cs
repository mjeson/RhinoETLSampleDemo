using FileHelpers;

namespace RhinoEtlDemo.FromCsv
{
    [DelimitedRecord(",")]
    public class DataRecord
    {
        public int Id;
        public string AWord;
    }
}
