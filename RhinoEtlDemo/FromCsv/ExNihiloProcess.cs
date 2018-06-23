using Rhino.Etl.Core;

namespace RhinoEtlDemo.FromCsv
{
    public class ExNihiloProcess : EtlProcess
    {
        protected override void Initialize()
        {
            Register(new JoinWordLists()
                .Left(new SimpleFileDataGet(@"..\..\FromCsv\UntransformedWordList1.csv"))
                .Right(new SimpleFileDataGet(@"..\..\FromCsv\UntransformedWordList2.csv")));
            Register(new TransformWord());
            Register(new PutData());
        }
    }
}
