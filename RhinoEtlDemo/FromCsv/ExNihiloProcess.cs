using System;
using System.Collections.Generic;
using System.IO;
using Rhino.Etl.Core;

namespace RhinoEtlDemo.FromCsv
{
    public class ExNihiloProcess : EtlProcess
    {
        public ExNihiloProcess(List<DataRecord> resultList)
        {
            _resultList = resultList;
        }

        private readonly List<DataRecord> _resultList;

        protected override void Initialize()
        {
            string appDir = AppDomain.CurrentDomain.BaseDirectory;

            Register(new JoinWordLists()
                .Left(new SimpleFileDataGet(Path.Combine(appDir, @".\FromCsv\UntransformedWordList1.csv")))
                .Right(new SimpleFileDataGet(Path.Combine(appDir, @".\FromCsv\UntransformedWordList2.csv"))));
            Register(new TransformWord());
            Register(new PutData(_resultList));
        }
    }
}
