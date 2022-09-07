using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RhinoEtlDemo.FromCsv;

namespace RhinoEtlDemo.Test
{
    [TestClass]
    public class ExNihiloProcessTest
    {
        [TestMethod]
        public void Execute_Success()
        {
            var resultList = new List<DataRecord>();

            Console.WriteLine("----Lets create a Rhino-ETL ----");
            Console.WriteLine("--------------------------------");
            // Here is the actual work. 
            var exNihiloP = new ExNihiloProcess(resultList);
            exNihiloP.Execute();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("----Hit any Rhino to exit------");

            JArray expectedJson = JArray.Parse(@"[{""Id"":1,""AWord"":""hello world""},{""Id"":2,""AWord"":""SSIS sucks""}]");
            JArray actualJson = JArray.Parse(JsonConvert.SerializeObject(resultList));
            Assert.IsTrue(JArray.DeepEquals(expectedJson, actualJson));
        }
    }
}
