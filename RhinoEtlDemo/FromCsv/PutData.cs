using Rhino.Etl.Core;
using Rhino.Etl.Core.Operations;
using System;
using System.Collections.Generic;

namespace RhinoEtlDemo.FromCsv
{
    public class PutData : AbstractOperation
    {
        public override IEnumerable<Row> Execute(IEnumerable<Row> rows)
        {
            foreach (Row row in rows)
            {
                var record = new DataRecord
                {
                    Id = (int)row["Id"],
                    AWord = (string)row["AWord"]
                };
                Console.WriteLine(record.AWord);
            }
            yield break;
        }
    }
}
