using RhinoEtlDemo.FromCsv;
using System;
using System.Collections.Generic;
using RhinoEtlDemo.FromDb;

namespace RhinoEtlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            testCsv();
            //fromDb();
        }

        private static void fromDb()
        {
            Console.WriteLine("----RunBuildInfosProcess------");
            var process = new RunBuildInfosProcess();
            process.Execute();
            Console.WriteLine("----Hit any key to exit------");
            Console.ReadKey();
        }

        private static void testCsv()
        {
            var resultList = new List<DataRecord>();

            Console.WriteLine("----Lets create a Rhino-ETL ----");
            Console.WriteLine("--------------------------------");
            // Here is the actual work. 
            var exNihiloP = new ExNihiloProcess(resultList);
            exNihiloP.Execute();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("----Hit any Rhino to exit------");
            Console.ReadKey();
        }
    }
}
