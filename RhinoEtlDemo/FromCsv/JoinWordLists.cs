using Rhino.Etl.Core;
using Rhino.Etl.Core.Operations;

namespace RhinoEtlDemo.FromCsv
{
    public class JoinWordLists : JoinOperation
    {
        protected override void SetupJoinConditions()
        {
            InnerJoin
                .Left("Id")
                .Right("Id");
        }

        protected override Row MergeRows(Row leftRow, Row rightRow)
        {
            Row row = leftRow.Clone();
            row["AWord"] = leftRow["AWord"].ToString() + " " +
                                       rightRow["AWord"].ToString();
            return row;
        }
    }
}
