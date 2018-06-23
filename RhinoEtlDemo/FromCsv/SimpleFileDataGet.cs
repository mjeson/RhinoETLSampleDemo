using Rhino.Etl.Core;
using Rhino.Etl.Core.Files;
using Rhino.Etl.Core.Operations;
using System.Collections.Generic;

namespace RhinoEtlDemo.FromCsv
{
    public class SimpleFileDataGet : AbstractOperation
    {
        public SimpleFileDataGet(string inPutFilepath)
        {
            FilePath = inPutFilepath;
        }
        public string FilePath { get; set; }
        public override IEnumerable<Row> Execute(IEnumerable<Row> rows)
        {
            using (FileEngine file = FluentFile.For<DataRecord>().From(FilePath))
            {
                foreach (object obj in file)
                {
                    yield return Row.FromObject(obj);
                }
            }
        }
    }
}
