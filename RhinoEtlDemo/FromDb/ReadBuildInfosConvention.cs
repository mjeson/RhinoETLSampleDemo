using Rhino.Etl.Core.ConventionOperations;
using System.Configuration;

namespace RhinoEtlDemo.FromDb
{
    public class ReadBuildInfosConvention : ConventionInputCommandOperation
    {
        public ReadBuildInfosConvention(ConnectionStringSettings csSettings) : base(csSettings)
        {
            Command = "SELECT [Key], [Value] FROM BuildInfos WITH (NOLOCK);";
        }
    }
}
