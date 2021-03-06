using System;

namespace TSQLGenCore.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var tsqlGen = new TSQLGen.TSQLGen<TSQLGen.Console.Models.SampleModel>(TSQLGen.DatabaseType.MSSQL);
            tsqlGen.ParameterPrefix = "SELECT SCOPE_IDENTITY()";

            System.Console.Write(tsqlGen.GetInsertCommand());
            System.Console.Write("\n\n");
            System.Console.Write(tsqlGen.GetUpdateCommand(null));
            System.Console.Write("\n\n");
            System.Console.Write(tsqlGen.GetDeleteCommand());
            System.Console.Write("\n\n");
            System.Console.Write(tsqlGen.GetSelectAllCommand());
            System.Console.Write("\n\n");
            System.Console.Write(tsqlGen.GetSelectByKeyCommand());
            System.Console.Write("\n\n");

            System.Console.ReadKey();
        }
    }
}
