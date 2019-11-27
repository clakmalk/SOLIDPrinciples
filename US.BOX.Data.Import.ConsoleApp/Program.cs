using System;

namespace US.BOX.Data.Import.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Statr Importing File");
            Importer importer = new Importer();
            importer.ImportFile(@"c:\\temp\data.txt");
            Console.ReadLine();
        }
    }
}
