using Rhino.Etl.Core;
using Rhino.Etl.Core.Operations;
using System.Data;


namespace RhinoEtlDemo.FromDb
{
    public class ReadBuildInfos : InputCommandOperation
    {
        public ReadBuildInfos(string connectionStringName)
            : base(connectionStringName)
        {
        }

        protected override Row CreateRowFromReader(IDataReader reader)
        {
            return Row.FromReader(reader);
        }

        protected override void PrepareCommand(IDbCommand cmd)
        {
            cmd.CommandText = "SELECT [Key], [Value] FROM dbo.BuildInfos WITH (NOLOCK);";
            cmd.CommandType = CommandType.Text;
        }
    }
}