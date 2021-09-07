using System;

namespace test_project_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataReader = new DataReader();
            var content = dataReader.ReadData();

            Console.WriteLine(content);


            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
