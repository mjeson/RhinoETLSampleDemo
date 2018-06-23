using Rhino.Etl.Core;
using System.Configuration;

namespace RhinoEtlDemo.FromDb
{
    public class RunBuildInfosProcess : EtlProcess
    {
        protected override void Initialize()
        {
            var csString = new ConnectionStringSettings("myConnection2",
                "Server=yourdatabasehere.database.windows.net;Database=MyDbName;User ID=youruser;Password=yourpassword",
                "System.Data.SqlClient");

            Register(new ReadBuildInfosConvention(csString));
            //Register(new ReadBuildInfos("myConnection"));
            Register(new PutData());
        }
    }
}
