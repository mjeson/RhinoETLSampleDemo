using Rhino.Etl.Core;
using Rhino.Etl.Core.Operations;
using System.Collections.Generic;
using System.Linq;

namespace RhinoEtlDemo.FromCsv
{
    public class TransformWord : AbstractOperation
    {
        public override IEnumerable<Row> Execute(IEnumerable<Row> rows)
        {
            foreach (Row row in rows)
            {
                var revWord = (string)row["AWord"];
                row["AWord"] = new string(revWord.ToCharArray().Reverse().ToArray());
                yield return row;
            }
        }
    }
}
