using Rhino.Etl.Core;
using Rhino.Etl.Core.Operations;
using System;
using System.Collections.Generic;

namespace RhinoEtlDemo.FromDb
{
    public class PutData : AbstractOperation
    {
        public override IEnumerable<Row> Execute(IEnumerable<Row> rows)
        {
            foreach (Row row in rows)
            {
                var record = new BuildInfo
                {
                    Key = (string)row["Key"],
                    Value = (string)row["Value"]
                };
                Console.WriteLine($"{record.Key} {record.Value}");
            }
            yield break;
        }
    }
}
