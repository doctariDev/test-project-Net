using System;

namespace test_project_Net
{
    /// <summary>
    /// start class of test project
    /// </summary>
    class Program
    {

        /// <summary>
        /// use DataReader to get content
        /// and display with console
        /// </summary>
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
